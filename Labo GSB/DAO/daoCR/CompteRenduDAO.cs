using Labo_GSB.Metier.metierCR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labo_GSB.DAO.daoCR
{
    class CompteRenduDAO : DAO<CompteRendu>
    {
        public override void Create(CompteRendu compteRendu)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "INSERT INTO compterendu (idVisiteurMedical,idContact,idEtablissement,titre,contenu,date) VALUES (@idVisiteurMedical,@idContact,@idEtablissement,@titre,@contenu,@date); SELECT SCOPE_IDENTITY()";
            commande.Parameters.AddWithValue("@idVisiteurMedical", compteRendu.IdVisiteurMedical);
            commande.Parameters.AddWithValue("@idContact", compteRendu.IdContact);
            commande.Parameters.AddWithValue("@idEtablissement", compteRendu.IdEtablissement);
            commande.Parameters.AddWithValue("@titre", compteRendu.Titre);
            commande.Parameters.AddWithValue("@contenu", compteRendu.Contenu);
            commande.Parameters.AddWithValue("@date", compteRendu.Date);

            Int32 newId = (Int32)commande.ExecuteScalar();
            compteRendu.setId(newId);
        }

        public override void Delete(CompteRendu compteRendu)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            int id = compteRendu.getId();
            commande.CommandText = "DELETE * FROM compterendu WHERE id = @id";
            commande.Parameters.AddWithValue("@id", id);
            commande.ExecuteNonQuery();

        }

        public override void Read(int id)
        {
            CompteRendu compteRendu = null;
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
                string Titre = datareader.GetString(4);
                string Contenu = datareader.GetString(5);
                DateTime Date = datareader.GetDateTime(6);
                compteRendu = new CompteRendu(id,idVisiteurMedical,idContact,idEtablissement,titre,contenu,date);
            }
            datareader.Close();
            return compteRendu;
        }

        public override void Update(CompteRendu compteRendu)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "UPDATE compterendu  SET idVisiteurMedical = @idVisiteurMedical, idContact = @idContact, idEtablissement = @idEtablissement, titre = @titre contenu = @contenu date = @date WHERE id = @id";

            commande.Parameters.AddWithValue("@id", compteRendu.getId());
            commande.Parameters.AddWithValue("@idVisiteurMedical", compteRendu.getIdVisiteurMedical());
            commande.Parameters.AddWithValue("@idContact", compteRendu.getIdContact());
            commande.Parameters.AddWithValue("@idEtablissement", compteRendu.getIdEtablissement());
            commande.Parameters.AddWithValue("@titre", compteRendu.getTitre());
            commande.Parameters.AddWithValue("@contenu", compteRendu.getContenu());
            commande.Parameters.AddWithValue("@date", compteRendu.getDate());
            commande.ExecuteNonQuery();
        }
    }
}
