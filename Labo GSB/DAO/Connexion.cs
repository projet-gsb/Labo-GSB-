using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO
{
    
        using System.Data.SqlClient;
class Connexion
    {
        private static SqlConnection LaConnexion { get; set; } = null;
        public static SqlConnection GetInstance()
        {
            // Préparation de la connexion à la base de données
            if (LaConnexion == null)
            {
                string connectionString = "Data Source=NOMSERVER Initial Catalog = gsb-gestion; User Id = login; Password = mdp; ";
            LaConnexion = new SqlConnection(connectionString);
                try
                {
                    // Connexion à la base de données
                    LaConnexion.Open();
                    Console.WriteLine("connecté");
                }
                catch (Exception ex)
                { Console.WriteLine("PROBLEME " + ex.Message); }
            }
            return LaConnexion;
        }
        private Connexion() { }
        
    }
}

