using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class Produit
    {
        public int Id  { get; protected set ; }
        public string Designation { get; protected set; }
        public int Quantite { get; protected set; }
        public double Tarif { get; protected set; }

        public Produit(int id, string designation, int quantite, int tarif)
        {
            this.Id = id;
            this.Designation = designation;
            this.Quantite = quantite;
            this.Tarif = tarif;
        }
    }
}
