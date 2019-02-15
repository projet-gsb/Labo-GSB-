using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.metierCR
{
    class CompteRendu
    {
        private int _id;
        private int _idVisiteurMedical;
        private int _idContact;
        private int _idEtablissement;
        private string _titre;
        private string _contenu;
        private DateTime _date;

        public int Id { get => _id; set => _id = value; }
        public int IdVisiteurMedical { get => _idVisiteurMedical; protected set => _idVisiteurMedical = value; }
        public int IdContact { get => _idContact; protected set => _idContact = value; }
        public int IdEtablissement { get => _idEtablissement; protected set => _idEtablissement = value; }
        public string Titre { get => _titre; protected set => _titre = value; }
        public string Contenu { get => _contenu; protected set => _contenu = value; }
        public DateTime Date { get => _date; protected set => _date = value; }

        public CompteRendu(int id, int idVisiteurMedical, int idContact, int idEtablissement, string titre, string contenu, DateTime date)
        {
            this.Id = id;
            this.IdVisiteurMedical = idVisiteurMedical;
            this.IdContact = idContact;
            this.IdEtablissement = idEtablissement;
            this.Titre = titre;
            this.Contenu = contenu;
            this.Date = date;
        }
    }
}
