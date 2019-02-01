using Labo_GSB.Metier.metierCR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.Metier.personne
{
    public interface IPersonne
    {

    }

    public abstract class Personne : IPersonne
    {
        private string _nom;
        private int _id;
        private string _prenom;
        private string _mel;
        private string _numeroTelephone;

        public int Id { get => _id;  set => _id = value; }
        public string Nom { get => _nom; protected set => _nom = value; }
        public string Prenom { get => _prenom; protected set => _prenom = value; }
        public string Mel { get => _mel; protected set => _mel = value; }
        public string NumeroTelephone { get => _numeroTelephone; protected set => _numeroTelephone = value; }

        protected Personne(int id, string nom, string prenom, string mel, string numeroTelephone)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mel = mel;
            this.NumeroTelephone = numeroTelephone;
        }


    }

    class VisiteurMedical : Personne

    {
        private DateTime _dateEmbauche;
        private string _zoneGeographique;
        private List<Etablissement> _client;

        public DateTime DateEmbauche { get => _dateEmbauche; protected set => _dateEmbauche = value; }
        public string ZoneGeographique { get => _zoneGeographique; protected set => _zoneGeographique = value; }
        public List<Etablissement> Client { get => _client; protected set => _client = value; }

        public VisiteurMedical(DateTime dateEmbauche, string zoneGeographique, List<Etablissement> client, int idPersonne,
                                    string nom, string prenom, string mel, string numeroTelephone)
                                        : base(idPersonne, nom, prenom, mel, numeroTelephone)
        {
            this.DateEmbauche = dateEmbauche;
            this.ZoneGeographique = zoneGeographique;
            this.Client = client;
        }

        public VisiteurMedical(DateTime dateEmbauche, string zoneGeographique, int idPersonne, string nom, string prenom,
                                        string mel, string numeroTelephone) : base(idPersonne, nom, prenom, mel, numeroTelephone)
        {
            this.DateEmbauche = dateEmbauche;
            this.ZoneGeographique = zoneGeographique;

        }
    }
    class Contact : Personne
    {
        private string _poste;
        private string _commentaire;
        private List<Etablissement> _employeur;

        public string Poste { get => _poste; protected set => _poste = value; }
        public string Commentaire { get => _commentaire; protected set => _commentaire = value; }
        public List<Etablissement> Employeur { get => _employeur; protected set => _employeur = value; }

        public Contact(string poste, string commentaire, List<Etablissement> employeur, int idPersonne, string nom, string prenom,
                                        string mel, string numeroTelephone)
                                        : base(idPersonne, nom, prenom, mel, numeroTelephone)
        {
            this.Poste = poste;
            this.Commentaire = commentaire;
            this.Employeur = employeur;
        }
    }
}