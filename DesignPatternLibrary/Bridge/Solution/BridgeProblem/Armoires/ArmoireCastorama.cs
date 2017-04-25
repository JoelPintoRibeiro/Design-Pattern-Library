using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeProblem.Taille;

namespace BridgeProblem
{
    public class ArmoireCastorama : Armoire
    {
        public ArmoireCastorama(ITaille taille) : base(taille)
        {
        }

        public override void OuvrirPorte()
        {
            Console.WriteLine("L'amoire de taille : " + taille.DonneTaille() + " Castorama s'ouvre");
        }
    }
}
