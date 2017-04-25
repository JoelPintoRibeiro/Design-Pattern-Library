using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public class ArmoireIkea : IArmoire
    {
        public ITaille taille
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void OuvrirPorte()
        {
            Console.WriteLine("L'amoire normale Ikea s'ouvre");
        }
    }
}
