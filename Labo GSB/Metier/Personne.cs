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
    }

    class VisiteurMedical : Personne
    {
    }

    class Contact : Personne
    {
    }
}