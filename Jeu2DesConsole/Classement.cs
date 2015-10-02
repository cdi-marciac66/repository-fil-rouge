using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Jeu2Des
{
    public class Classement
    {

        public ISerialisation Serial;

        public List<Entree> Rank;
              
        
        public Classement()
        {
            Rank = new List<Entree>();
            
            
        }

        public void AppelSerialisation(string reponse)
        {
            Fabrique Fabrique = new Fabrique();
            Serial = Fabrique.AppelInstance(reponse);
            List<Entree> result = Serial.Load();
            if (result != null)
                Rank = result;

        }
        
        public void AjouterEntree(Joueur Joueur)
        {
            
            Entree Entree = new Entree();
            Entree.Nom = Joueur.Nom;
            Entree.Score = Joueur.Score;
            Rank.Add(Entree);
            Rank.Sort();
            Rank.Reverse();
            Serial.Save(Rank);
       }

        public void TopN(string nbre)
        {
            
            
            int count = Int32.Parse(nbre);

            if (count <= Rank.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Rang : {0}, Nom : {1}, Score : {2}", i+1, Rank[i].Nom, Rank[i].Score);
                }
            }

            else
            {
                Console.WriteLine("Il y a moins de {0} joueur(s) dans ce classement", count );
            }
            
       }

       

       
    }
}
