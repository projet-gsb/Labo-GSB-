using Labo_GSB.Metier.metierCR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO.daoCR
{
    class ProduitDAO : DAO<Produit>
    {
        public override void Create(Produit produit)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "INSERT INTO produit (designation,quantite,tarif) VALUES (@designation,@quantite,@tarif); SELECT SCOPE_IDENTITY()";
            commande.Parameters.AddWithValue("@designation", produit.Designation);
            commande.Parameters.AddWithValue("@quantite", produit.Quantite);
            commande.Parameters.AddWithValue("@tarif", produit.Tarif);
            
            int newId = (int)commande.ExecuteScalar();
            produit.Id = newId;
        }

        public override void Delete(Produit produit)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            int id = produit.Id;
            commande.CommandText = "DELETE * FROM produit WHERE id = @id";
            commande.Parameters.AddWithValue("@id", id);
            commande.ExecuteNonQuery();
        }

        public override Produit Read(int id)
        {
            Produit produit = null;
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "SELECT * FROM produit WHERE id = @id";
            commande.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = commande.ExecuteReader();
            while (datareader.Read())
            {
                int Id = id;
                string designation = datareader.GetString(1);
                int quantite = datareader.GetInt32(2);
                double tarif = datareader.GetDouble(3);

                produit = new Produit(id, designation, quantite, tarif);
            }
            datareader.Close();

            return produit;
        }

        public override void Update(Produit produit)
        {
            SqlCommand commande = Connexion.GetInstance().CreateCommand();
            commande.CommandText = "UPDATE produit  SET designation = @designation, quantite = @quantite, tarif = @tarif WHERE id = @id";

            commande.Parameters.AddWithValue("@id", produit.Id);
            commande.Parameters.AddWithValue("@id", produit.Designation);
            commande.Parameters.AddWithValue("@id", produit.Quantite);
            commande.Parameters.AddWithValue("@id", produit.Tarif);

            commande.ExecuteNonQuery();
        }
    }
}
