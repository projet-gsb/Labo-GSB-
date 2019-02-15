using Labo_GSB.Metier.metierCR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO.daoCR
{
    class EchantillonDAO : DAO<Echantillon>
    {
        public override void Create(Echantillon echantillon)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "INSERT INTO echantillon (idCompteRendu,idProduit,quantite) VALUES (@idCompteRendu,@idProduit,@quantite); SELECT SCOPE_IDENTITY()";
            commande.Parameters.AddWithValue("@designation", echantillon.IdCompteRendu);
            commande.Parameters.AddWithValue("@quantite", echantillon.IdProduit);
            commande.Parameters.AddWithValue("@tarif", echantillon.Quantite);

            int newId = (int)commande.ExecuteScalar();
            echantillon.IdCompteRendu = newId;
        }

        public override void Delete(Echantillon echantillon)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            int id = echantillon.IdCompteRendu;
            commande.CommandText = "DELETE * FROM produit WHERE id = @idCompteRendu";
            commande.Parameters.AddWithValue("@idCompteRendu", id);
            commande.ExecuteNonQuery();
        }

        public override Echantillon Read(int id)
        {
            Echantillon echantillon = null;
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "SELECT * FROM produit WHERE id = @idCompteRendu";
            commande.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = commande.ExecuteReader();
            while (datareader.Read())
            {
                int idCompteRendu = datareader.GetInt32(0);
                int idProduit = datareader.GetInt32(1);
                int quantite = datareader.GetInt32(2);
                

                echantillon = new Echantillon(idCompteRendu, idProduit,quantite);
            }
            datareader.Close();

            return echantillon;
        }

        public override void Update(Echantillon echantillon)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "UPDATE echantillon  SET idCompteRendu = @idCompteRendu, idProduit = @idProduit, quantite = @quantite WHERE id = @idCompteRendu";

            commande.Parameters.AddWithValue("@id", echantillon.IdCompteRendu);
            commande.Parameters.AddWithValue("@id", echantillon.IdProduit);
            commande.Parameters.AddWithValue("@id", echantillon.Quantite);
            

            commande.ExecuteNonQuery();
        }
    }
}
