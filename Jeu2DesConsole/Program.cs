using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu2Des Jeu = Jeu2Des.GetInstance();

            Console.WriteLine("Voulez sauver en Binaire ou en Xml (Tapez 1 ou 2) ?");
            string reponse = Console.ReadLine();

            Jeu.Classement.AppelSerialisation(reponse);

            while (Console.ReadLine() != "quit")
            {
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("1. Jouer" + Environment.NewLine);
            Console.WriteLine("2. Voir Classement" + Environment.NewLine);
            Console.WriteLine("3. Voir le Top N" + Environment.NewLine);
            Console.WriteLine("4. Quitter le jeu" + Environment.NewLine);

            string line;
            line = Console.ReadLine();
            if (line == "1")
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Quel est votre nom ?");
                string name;
                name = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);
                Jeu.JouerPartie(name);
                
            }
            else if (line == "2")
            {
                Console.WriteLine(Environment.NewLine);
                Jeu.VoirClassement();
                Console.WriteLine(Environment.NewLine);
                
            }
            else if (line == "3")
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Combien voulez-vous afficher de joueurs ?");
                string nbre = Console.ReadLine();
                Jeu.Classement.TopN(nbre);
                Console.WriteLine(Environment.NewLine);

            }
            else if (line == "4")
            {
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("Veuillez taper 1, 2 ou 3");
                Console.ReadLine();
            }

            }

            
        }
    }
}
