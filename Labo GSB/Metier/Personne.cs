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
        public int Id { get; }
        public string Nom { get; protected set; }
        public string Prenom { get; protected set; }
        public string Mel { get; protected set; }
        public string NumeroTelephone { get; protected set; }

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
        public DateTime DateEmbauche { get; protected set; }
        public string ZoneGeographique { get; protected set; }
        public List<Etablissement> Client { get; protected set; }

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
    {   public string Poste { get; protected set; }
        public string Commentaire { get; protected set; }
        public List<Etablissement> Employeur { get; protected set; }

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