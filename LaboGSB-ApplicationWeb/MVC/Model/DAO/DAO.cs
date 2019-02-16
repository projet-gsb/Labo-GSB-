using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_GSB.DAO
{
    public abstract class DAO <T>
    {
        public abstract void Create(T objet);


        public abstract T Read(int id);


        public abstract void Update(T objet);


        public abstract void Delete(T objet);
       
    }
}

