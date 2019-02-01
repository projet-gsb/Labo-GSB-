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

            int newId = (int)commande.ExecuteScalar();
            compteRendu.Id = newId;
        }

        public override void Delete(CompteRendu compteRendu)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            int id = compteRendu.Id;
            commande.CommandText = "DELETE * FROM compterendu WHERE id = @id";
            commande.Parameters.AddWithValue("@id", id);
            commande.ExecuteNonQuery();

        }

        public override CompteRendu Read(int id)
        {
            CompteRendu compteRendu = null;
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "SELECT * FROM compterendu WHERE id = @id";
            commande.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = commande.ExecuteReader();
            while(datareader.Read())
            {
                int Id = id;
                int idVisiteurMedical = datareader.GetInt32(1); ;
                int idContact = datareader.GetInt32(2);
                int idEtablissement = datareader.GetInt32(3);
                string titre = datareader.GetString(4);
                string contenu = datareader.GetString(5);
                DateTime date = datareader.GetDateTime(6);
                compteRendu = new CompteRendu(id,idVisiteurMedical,idContact,idEtablissement,titre,contenu,date);
            }
            datareader.Close();

            return compteRendu;

        }

        public override void Update(CompteRendu compteRendu)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "UPDATE compterendu  SET idVisiteurMedical = @idVisiteurMedical, idContact = @idContact, idEtablissement = @idEtablissement, titre = @titre contenu = @contenu date = @date WHERE id = @id";

            commande.Parameters.AddWithValue("@id", compteRendu.Id);
            commande.Parameters.AddWithValue("@idVisiteurMedical", compteRendu.IdVisiteurMedical);
            commande.Parameters.AddWithValue("@idContact", compteRendu.IdContact);
            commande.Parameters.AddWithValue("@idEtablissement", compteRendu.IdEtablissement);
            commande.Parameters.AddWithValue("@titre", compteRendu.Titre);
            commande.Parameters.AddWithValue("@contenu", compteRendu.Contenu);
            commande.Parameters.AddWithValue("@date", compteRendu.Date);
            commande.ExecuteNonQuery();
        }
    }
}
