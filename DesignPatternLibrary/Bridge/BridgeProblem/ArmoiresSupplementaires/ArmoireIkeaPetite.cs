using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public class ArmoireIkeaPetite : IArmoire
    {
        public void OuvrirPorte()
        {
            Console.WriteLine("La petite armoire Ikea s'ouvre");
        }
    }
}
