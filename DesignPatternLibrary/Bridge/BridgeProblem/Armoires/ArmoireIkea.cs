using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public class ArmoireIkea : IArmoire
    {

        public ArmoireIkea(ITaille taille)
        {
            this.Taille = taille;
        }

        public ITaille Taille { get; private set; }

        public void OuvrirPorte()
        {
            Console.WriteLine("L'amoire normale Ikea s'ouvre");
        }
    }
}
