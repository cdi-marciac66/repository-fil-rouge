using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2Des
{
    public class SerializeXml : ISerialisation
    {

        public List<Entree> Rank;

        public SerializeXml()
        {
            
        }
                
        public List<Entree> Load()
        {
            List<Entree> entry = new List<Entree>();
            entry = null;

            if (File.Exists("sav.xml"))
            {
                Stream Fichier = File.OpenRead("sav.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Entree>));
                entry = (List<Entree>)serializer.Deserialize(Fichier);

                Fichier.Close();

            }

            return entry;

        }

        public void Save(List<Entree> rank)
        {
            using (FileStream str = File.Create("sav.xml"))
            {
                XmlSerializer bf = new XmlSerializer(rank.GetType());
                bf.Serialize(str, rank);
            }

        }
        
    }
}
