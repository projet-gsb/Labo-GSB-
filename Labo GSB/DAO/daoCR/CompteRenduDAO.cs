using Labo_GSB.Metier.metierCR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO.daoCR
{
    class CompteRenduDAO : DAO<CompteRendu>
    {
        public override void Create(CompteRendu objet)
        {
            throw new NotImplementedException();
        }

        public override void Delete(CompteRendu objet)
        {
            throw new NotImplementedException();
        }

        public override void Read(int id)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "SELECT * FROM compterendu WHERE id = @id";
            commande.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = commande.ExecuteReader();
            while(datareader.Read())
            {
                int Id = id;
                int IdVisiteurMedical = idVisiteurMedical;
                int IdContact = idContact;
                int IdEtablissement = idEtablissement;





                string nom = dataReader.GetString(1);

            }
        }

        public override void Update(CompteRendu objet)
        {
            throw new NotImplementedException();
        }
    }
}
