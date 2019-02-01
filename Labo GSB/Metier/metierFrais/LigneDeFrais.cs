using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierFrais
{
    // BDD
    class LigneDeFrais
    {
        public int Id { get; }
        public DateTime Date { get; protected set; }
        public int Montant { get; protected set; }
        public string Libelle { get; protected set; }
        public bool Validee { get; protected set; }
        public bool Refusee { get; protected set; }
        public bool HorsForfait { get; protected set; }
        public bool Report { get; protected set; }

        public LigneDeFrais(
            int id,
            DateTime date,
            int montant,
            string libelle,
            bool validee,
            bool refusee,
            bool horsForfait,
            bool report
            )
        {
            this.Id = id;
            this.Date = date;
            this.Montant = montant;
            this.Libelle = libelle;
            this.Validee = validee;
            this.Refusee = refusee;
            this.HorsForfait = horsForfait;
            this.Report = report;
        }

    }

}
