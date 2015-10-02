using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    public class De
    {
        public int valeur { get; set; }

        private static Random rdm = new Random();

        public De()
        {
            valeur = 0;

        }

        public int Lancer()
        {
            int result;
            result = rdm.Next(1, 7);

            return result;
        }
    }
}
