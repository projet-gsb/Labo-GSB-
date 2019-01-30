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
        public override void Create(Etablissement objet)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Etablissement objet)
        {
            throw new NotImplementedException();
        }

        public override void Read(int id)
        {
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
                Etablissement etablissement = new Etablissement(idEtablissement, nom, adresse, mel, type);
            }
            dataReader.Close();
        }

        public override void Update(Etablissement objet)
        {
            throw new NotImplementedException();
        }
    }
}
