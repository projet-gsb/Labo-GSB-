using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class Echantillon
    {
        private int _idCompteRendu;
        private int _idProduit;
        private int _quantite;

        public int IdCompteRendu { get => _idCompteRendu; set => _idCompteRendu = value; }
        public int IdProduit { get => _idProduit; protected set => _idProduit = value; }
        public int Quantite { get => _quantite; protected set => _quantite = value; }

        public Echantillon(int idCompteRendu, int idProduit,int quantite)
        {
            this.IdCompteRendu = idCompteRendu;
            this.IdProduit = idProduit;
            this.Quantite = quantite;
        }
    }
}
