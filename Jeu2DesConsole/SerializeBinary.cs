using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    public class SerializeBinary : ISerialisation
    {
        public SerializeBinary()
        {
            
        }

        public List<Entree> Load()
        {
            List<Entree> entry = new List<Entree>();
            entry = null;
            
            if (File.Exists("sav.txt"))
            {
                
                
                Stream Fichier = File.OpenRead("sav.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                
                entry = (List<Entree>)serializer.Deserialize(Fichier);

                Fichier.Close();
            
            }

            return entry;
        }

        public void Save(List<Entree> rank)
        {
            using (FileStream str = File.Create("sav.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, rank);
            }

        }
    }
}
