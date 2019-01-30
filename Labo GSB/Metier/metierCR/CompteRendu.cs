using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class CompteRendu
    {
        public int Id { get; protected set; }
        public int IdVisiteurMedical { get; protected set; }
        public int IdContact { get; protected set; }
        public int IdEtablissement { get; protected set; }
        public string Titre { get; protected set; }
        public string Contenu { get; protected set; }
        public DateTime Date { get; protected set; }

        public CompteRendu( int id, int idVisiteurMedical, int idContact, int idEtablissement, string titre, string contenu, DateTime date)
        {
            this.Id = Id;
            this.IdVisiteurMedical = idVisiteurMedical;
            this.IdContact = idContact;
            this.IdEtablissement = idEtablissement;
            this.Titre = titre;
            this.Contenu = contenu;
            this.Date = date;
        }
    }
}
