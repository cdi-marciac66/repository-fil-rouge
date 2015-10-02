using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    public interface ISerialisation
    {
        List<Entree> Load();

        void Save(List<Entree> rank);
    }
}
