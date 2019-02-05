using Labo_GSB.Metier.metierFrais;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO.daoFrais
{
    class LigneDeFraisDAO : DAO<LigneDeFrais>
    {
        public override void create(LigneDeFrais lignedefrais)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "INSERT INTO lignedefrais (date, montant, libelle, validee, refusee, horsForfait, report) VALUES(@date, @montant, @libelle, @validee, @refusee, @horsForfait, @report); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@date", lignedefrais.Date);
            command.Parameters.AddWithValue("@montant", lignedefrais.Montant);
            command.Parameters.AddWithValue("@libelle", lignedefrais.Libelle);
            command.Parameters.AddWithValue("@validee", lignedefrais.Validee);
            command.Parameters.AddWithValue("@refusee", lignedefrais.Refusee);
            command.Parameters.AddWithValue("@horsForfait", lignedefrais.HorsForfait);
            command.Parameters.AddWithValue("@report", lignedefrais.Report);

            // Exécution de la requête
            // command.ExecuteNonQuery();
            // pour récupérer la clé générée
            Int32 newId = (Int32)command.ExecuteScalar();
            lignedefrais.setId(newId);
        }
    }
}
