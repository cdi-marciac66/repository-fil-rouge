using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    public class Jeu2Des
    {

        private De De1;
        private De De2;
        public Classement Classement;
        private Joueur Joueur;

        public List<Entree> Rank; 
        
        private Jeu2Des()
        {
            De1 = new De();
            De2 = new De();
            Classement = new Classement();
            
        }

        private static Jeu2Des Jeu;

        public static Jeu2Des GetInstance()
        {
            if (Jeu == null)
            {Jeu = new Jeu2Des();}
            return Jeu;

        }

        public void Jouer()
        {
            
        }

        public void JouerPartie(string nom)
        {

            Joueur = new Joueur();
            Joueur.Nom = nom;

            Joueur.Score = Joueur.Jouer(De1, De2);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Votre Score est : "+ Joueur.Score);
            Classement.AjouterEntree(Joueur);
            Console.WriteLine(Environment.NewLine);
            
            
        }

        public void VoirClassement()
        {
            for (int i = 0; i < Classement.Rank.Count; i++)
            {
                Console.WriteLine("Rang : {0}, Nom : {1}, Score : {2}", i + 1, Classement.Rank[i].Nom, Classement.Rank[i].Score);
            }
        }

           
   }
}
