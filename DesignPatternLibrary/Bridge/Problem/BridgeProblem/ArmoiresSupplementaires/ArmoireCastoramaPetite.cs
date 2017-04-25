using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public class ArmoireCastoramaPetite : IArmoire
    {
        public void OuvrirPorte()
        {
            Console.WriteLine("La petite armoire Castorama s'ouvre");
        }
    }
}
