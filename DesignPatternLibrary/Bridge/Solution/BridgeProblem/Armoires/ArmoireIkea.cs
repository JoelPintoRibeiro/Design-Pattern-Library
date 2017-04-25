using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeProblem.Taille;

namespace BridgeProblem
{
    public class ArmoireIkea : Armoire
    {
        public ArmoireIkea(ITaille taille) : base(taille)
        {
        }

        public override void OuvrirPorte()
        {
            Console.WriteLine("L'amoire de taille : "+taille.DonneTaille()+ " Ikea s'ouvre");
          
        }
    }
}
