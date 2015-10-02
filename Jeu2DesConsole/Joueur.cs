using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    public class Joueur
    {

        public string Nom { get; set; }
        public int Score { get; set; }

        public Joueur()
        {
            Score = 0;
        }

        public int Jouer(De De1, De De2)
        {
            for (int i = 1; i < 11; i++)
            {
                int result1, result2;
                result1 = De1.Lancer();
                result2 = De2.Lancer();
                Console.WriteLine("Dé 1 : "+result1+" et Dé 2 : "+result2);
                int result;
                result = result1 + result2;
                if (result == 7)
                {
                    this.Score += 10;

                }

            }

            return this.Score;
        }

    }
}
