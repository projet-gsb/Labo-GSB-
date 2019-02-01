using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class Produit
    {
        private int _id;
        private string _designation;
        private int _quantite;
        private double _tarif;

        public int Id { get => _id; set => _id = value; }
        public string Designation { get => _designation; protected set => _designation = value; }
        public int Quantite { get => _quantite; protected set => _quantite = value; }
        public double Tarif { get => _tarif; protected set => _tarif = value; }

        public Produit(int id, string designation, int quantite, double tarif)
        {
            this.Id = id;
            this.Designation = designation;
            this.Quantite = quantite;
            this.Tarif = tarif;
        }
    }
}
