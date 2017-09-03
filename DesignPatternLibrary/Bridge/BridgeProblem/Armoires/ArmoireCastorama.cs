using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public class ArmoireCastorama : IArmoire
    {
        public void OuvrirPorte()
        {
            Console.WriteLine("L'armoire normale Castorama s'ouvre");
        }
    }
}
