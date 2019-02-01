using Labo_GSB.Metier.metierCR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labo_GSB.DAO.daoCR
{
    class EtablissementDAO : DAO<Etablissement>
    {
        public override void Create(Etablissement etablissement)
        {
           SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "INSERT INTO etablissement (nom,adresse,numeroTelephone,mel,type) VALUES (@nom,@adresse,@numeroTelephone,@mel,@type); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@nom", etablissement.Nom);
            command.Parameters.AddWithValue("@adresse", etablissement.Adresse);
            command.Parameters.AddWithValue("@numeroTelephone", etablissement.NumeroTelephone);
            command.Parameters.AddWithValue("@mel", etablissement.Mel);
            command.Parameters.AddWithValue("@type", etablissement.Type);
            // Exécution de la requête
            // command.ExecuteNonQuery();
            // pour récupérer la clé générée
            int newId = (int)command.ExecuteScalar();
            etablissement.Id = newId;
        }

        public override Etablissement Read(int id)
        {
            Etablissement etablissement = null;
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT * FROM etablissement WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);
            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int idEtablissement = id;
                string nom = dataReader.GetString(1);
                string adresse = dataReader.GetString(2);
                string mel = dataReader.GetString(3);
                string type = dataReader.GetString(4);
                etablissement = new Etablissement(idEtablissement, nom, adresse, mel, type);
            }
            dataReader.Close();

            return etablissement;
        }

               public override void Update(Etablissement etablissement)

        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "UPDATE etablissement SET nom = @nom, adresse = @adresse, numeroTelephone = @numeroTelephone, mel = @mel type = @type WHERE id = @id";
            command.Parameters.AddWithValue("@id", etablissement.Id);
            command.Parameters.AddWithValue("@nom", etablissement.Nom);
            command.Parameters.AddWithValue("@adresse", etablissement.Adresse);
            command.Parameters.AddWithValue("@numeroTelephone", etablissement.NumeroTelephone);
            command.Parameters.AddWithValue("@mel", etablissement.Mel);
            command.Parameters.AddWithValue("@type", etablissement.Type);
            // Exécution de la requête
            command.ExecuteNonQuery();
        }

         public override void Delete(Etablissement etablissement)

        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            int idEtablissement = etablissement.Id;

            command.CommandText = "DELETE * FROM etablissement WHERE idEtablissement = @id";
            command.Parameters.AddWithValue("@id", idEtablissement);
            command.ExecuteNonQuery();

        }
    }
}
