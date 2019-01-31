using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class Etablissement
    {
        public int Id { get; protected set; }
        public string Nom { get; protected set; }
        public string Adresse { get; protected set; }
        public string Mel { get; protected set; }
        public string Type { get; protected set; }

        protected Etablissement(int id, string nom, string adresse, string mel, string type)
        {
            this.Id = id;
            this.Nom = nom;
            this.Adresse = adresse;
            this.Mel = mel;
            this.Type = type;
        }
    }

}
