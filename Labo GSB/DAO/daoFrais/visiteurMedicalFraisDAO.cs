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
    class VisiteurMedicalFraisDAO : DAO<VisiteurMedical>
    {

        public override void Read(int id)
        {
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
                VisiteurMedical visiteurMedical = new VisiteurMedical(dateEmbauche, zoneGeographique, idPersonne, nom, 
                                                                                        prenom, mel, numeroTelephone);

            }

            //List<Etablissement> client = dataReader[""];
            dataReader.Close();
          
        }

        public override void create(VisiteurMedical personne)

        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "INSERT INTO personne, visiteurmedical (nom,prenom,mel,numeroTelephone,dateEmbauche,zoneGeographique) " +
                                                                                "VALUES (@nom, @prenom,@mel,@numeroTelephone," +
                                                                                "@dateEmbauche,@zoneGeographique); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@nom", personne.Nom);
            command.Parameters.AddWithValue("@prenom",personne.Prenom);
            command.Parameters.AddWithValue("@mel",personne .Mel);
            command.Parameters.AddWithValue("@numeroTelephone", personne.NumeroTelephone);
            command.Parameters.AddWithValue("@dateEmbauche",personne.DateEmbauche);
            command.Parameters.AddWithValue("@zoneGeographique",personne.ZoneGeographique );
            // Exécution de la requête
            // command.ExecuteNonQuery();
            // pour récupérer la clé générée
            Int32 newId = (Int32)command.ExecuteScalar();
        }

        public override void Update(VisiteurMedical visiteurMedical)

        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "UPDATE personne SET nom = @nom, prenom = @prenom, mel = @mel, numeroTelephone = @numeroTelephone WHERE id = @id";
            command.Parameters.AddWithValue("@id", visiteurMedical.getId());
            command.Parameters.AddWithValue("@nom", visiteurMedical.getNom());
            command.Parameters.AddWithValue("@prenom", visiteurMedical.getPrenom());
            command.Parameters.AddWithValue("@mel", visiteurMedical.getMel());
            command.Parameters.AddWithValue("@numeroTelephone", visiteurMedical.getNumeroTelephone());
            // Exécution de la requête
            command.ExecuteNonQuery();

            command.CommandText = "UPDATE visiteurmedical SET dateEmbauche = @dateEmbauche, zoneGeographique = @zoneGeographique WHERE idPersonne = @id";
            command.Parameters.AddWithValue("@nom", visiteurMedical.getId());
            command.Parameters.AddWithValue("@nom", visiteurMedical.getDateEmbauche());
            command.Parameters.AddWithValue("@prenom", visiteurMedical.getZoneGeographique());
            // Exécution de la requête
            command.ExecuteNonQuery();
        }

        public override void Delete(VisiteurMedical visiteurMedical)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            int idVisiteurMedical = visiteurMedical.getId();

            command.CommandText = "DELETE * FROM visiteurmedical WHERE idPersonne = @id";
            command.Parameters.AddWithValue("@id", idVisiteurMedical);
            command.ExecuteNonQuery();

            command.CommandText = "DELETE * FROM personne WHERE id = @id";
            command.Parameters.AddWithValue("@id", idVisiteurMedical);
            command.ExecuteNonQuery();
        }

     }   
}
