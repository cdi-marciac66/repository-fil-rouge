using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2Des
{
    public class Fabrique
    {
       public Fabrique()
        {
            
        }

        public static ISerialisation AppelInstance(string reponse)
        {
            if (reponse == "1")
                {return new SerializeBinary();
                }
            else 
                {return new SerializeXml();
                }
            
        }

        

        

        

        
    }
}
