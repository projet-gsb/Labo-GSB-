using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class Etablissement
    {
        private int _id;
        private string _nom;
        private string _adresse;
        private string _numeroTelephone;
        private string _mel;
        private string _type;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; protected set => _nom = value; }
        public string Adresse { get => _adresse; protected set => _adresse = value; }
        public string NumeroTelephone { get => _numeroTelephone; protected set => _numeroTelephone = value; }
        public string Mel { get => _mel; protected set => _mel = value; }
        public string Type { get => _type; protected set => _type = value; }

        public Etablissement(int id, string nom, string adresse, string mel, string type)
        {
            this.Id = id;
            this.Nom = nom;
            this.Adresse = adresse;
            this.NumeroTelephone = NumeroTelephone;
            this.Mel = mel;
            this.Type = type;
        }
    }


}
