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

        public override void Create(VisiteurMedical personne)
        {
            throw new NotImplementedException();
        }



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
                VisiteurMedical visiteurMedical = new VisiteurMedical(dateEmbauche, zoneGeographique, idPersonne, nom, prenom, mel, numeroTelephone);

            }
            //List<Etablissement> client = dataReader[""];
            dataReader.Close();
        }

        public override void Update(VisiteurMedical personne)

        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "INSERT INTO PILOTE (nompil,adr,sal) VALUES (@nom, @adr,@sal); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@nom", "Faraday");
            command.Parameters.AddWithValue("@adr", "Dijon");
            command.Parameters.AddWithValue("@sal", 15999);
            // Exécution de la requête
            // command.ExecuteNonQuery();
            // pour récupérer la clé générée
            Int32 newId = (Int32)command.ExecuteScalar();
        }

        public override void Delete(VisiteurMedical personne)
        {
            throw new NotImplementedException();
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
                int idEtablissement = dataReader.GetString(0);
                int idVisiteurMedical = dataReader.GetString(1);

                EtablissementDAO etablissementDAO = new EtablissementDAO();
                Etablissement etablissement =  etablissementDAO->read(idEtablissement);
                
                listeClient.Add(etablissement);
            }
            dataReader.Close();
            return listeClient;
        }
    }
}
