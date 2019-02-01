﻿using Labo_GSB.DAO.daoCR;
using Labo_GSB.Metier.metierCR;
using Labo_GSB.Metier.personne;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO
{
    class VisiteurMedicalCRDAO : DAO<VisiteurMedical>
    {

        public override void Create(VisiteurMedical visiteurMedical)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "INSERT INTO personne (nom,prenom,mel,numeroTelephone) VALUES (@nom,@prenom,@mel,@numeroTelephone); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@nom", visiteurMedical.Nom);
            command.Parameters.AddWithValue("@prenom", visiteurMedical.Prenom);
            command.Parameters.AddWithValue("@mel", visiteurMedical.Mel);
            command.Parameters.AddWithValue("@numeroTelephone", visiteurMedical.NumeroTelephone);
            // Exécution de la requête
            // command.ExecuteNonQuery();
            // pour récupérer la clé générée
            int newId = (int)command.ExecuteScalar();
            visiteurMedical.Id = newId;

            command.CommandText = "INSERT INTO visiteurmedical (idPersonne,dateEmbauche,zoneGeographique) VALUES (@idPersonne,@dateEmbauche,@zoneGeographique)";
            command.Parameters.AddWithValue("@idPersonne", visiteurMedical.Id);
            command.Parameters.AddWithValue("@dateEmbauche", visiteurMedical.DateEmbauche);
            command.Parameters.AddWithValue("@zoneGeographique", visiteurMedical.ZoneGeographique);
            command.ExecuteNonQuery();
        }

        public override VisiteurMedical Read(int id)
        {
            VisiteurMedical visiteurMedical = null;
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT * FROM personne, visiteurmedical WHERE id = @id AND id = idPersonne";
            command.Parameters.AddWithValue("@id", id);
            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int idPersonne = id;
                string nom = dataReader.GetString(1);
                string prenom = dataReader.GetString(2);
                string mel = dataReader.GetString(3);
                string numeroTelephone = dataReader.GetString(4);
                DateTime dateEmbauche = dataReader.GetDateTime(6);
                string zoneGeographique = dataReader.GetString(7);
                List<Etablissement> client = RetrouverListeClient(id);
                visiteurMedical = new VisiteurMedical(dateEmbauche, zoneGeographique, client, idPersonne, nom, prenom, mel, numeroTelephone);
            }
            dataReader.Close();

            return visiteurMedical;
        }

        public override void Update(VisiteurMedical visiteurMedical)

        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "UPDATE personne SET nom = @nom, prenom = @prenom, mel = @mel, numeroTelephone = @numeroTelephone WHERE id = @id";
            command.Parameters.AddWithValue("@id", visiteurMedical.Id);
            command.Parameters.AddWithValue("@nom", visiteurMedical.Nom);
            command.Parameters.AddWithValue("@prenom", visiteurMedical.Prenom);
            command.Parameters.AddWithValue("@mel", visiteurMedical.Mel);
            command.Parameters.AddWithValue("@numeroTelephone", visiteurMedical.NumeroTelephone);
            // Exécution de la requête
            command.ExecuteNonQuery();

            command.CommandText = "UPDATE visiteurmedical SET dateEmbauche = @dateEmbauche, zoneGeographique = @zoneGeographique WHERE idPersonne = @id";
            command.Parameters.AddWithValue("@nom", visiteurMedical.Id);
            command.Parameters.AddWithValue("@nom", visiteurMedical.DateEmbauche);
            command.Parameters.AddWithValue("@prenom", visiteurMedical.ZoneGeographique);
            // Exécution de la requête
            command.ExecuteNonQuery();
        }

        public override void Delete(VisiteurMedical visiteurMedical)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            int idVisiteurMedical = visiteurMedical.Id;

            command.CommandText = "DELETE * FROM visiteurmedical WHERE idPersonne = @id";
            command.Parameters.AddWithValue("@id", idVisiteurMedical);
            command.ExecuteNonQuery();

            command.CommandText = "DELETE * FROM personne WHERE id = @id";
            command.Parameters.AddWithValue("@id", idVisiteurMedical);
            command.ExecuteNonQuery();
        }

        
        public List<Etablissement> RetrouverListeClient(int idVisiteurMedical)
        {
            List<Etablissement> listeClient = new List<Etablissement>();
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT * FROM relationcommerciale WHERE idVisiteurMedical = @idVisiteurMedical";
            command.Parameters.AddWithValue("@idVisiteurMedical", idVisiteurMedical);
            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int idEtablissement = dataReader.GetInt32(0);
                int idVisiteurMedical = dataReader.GetInt32(1);

                EtablissementDAO etablissementDAO = new EtablissementDAO();
                Etablissement etablissement = etablissementDAO.Read(idEtablissement);

                listeClient.Add(etablissement);
            }
            dataReader.Close();
            return listeClient;
        }
    }
}

