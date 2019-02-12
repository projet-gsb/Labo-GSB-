﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierFrais{
    
    //BDD
    class FicheDeFrais{

        public int Id { get; }
        public int IdVisiteurMedical { get; }
        public DateTime DateCreation { get; protected set; }
        public DateTime DateTraitement { get; protected set; }
        public bool MiseEnPaiement { get; protected set; }

        public FicheDeFrais (int id, int idvisiteurmedical, DateTime datecreation, DateTime datetraitement, bool miseenpaiement){
            this.Id = id;
            this.IdVisiteurMedical = idvisiteurmedical;
            this.DateCreation = datecreation;
            this.DateTraitement = datetraitement;
            this.MiseEnPaiement = miseenpaiement;
        }
    }
}