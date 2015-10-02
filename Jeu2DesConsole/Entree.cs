using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    [Serializable]
    public class Entree : IComparable<Entree>
    {
        public string Nom;
        public int Score;
        

        public int CompareTo(Entree entree)
        {
            Entree other = entree;
            return this.Score.CompareTo(other.Score);
        }

        public override string ToString()
        {
            return this.Nom + ", " + this.Score;
        }

        public override bool Equals(object obj)
        {
            if (obj is Entree)
            { 
                Entree e = (Entree)obj;
                return Score == e.Score ;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + this.Score;
        }

    }
}
