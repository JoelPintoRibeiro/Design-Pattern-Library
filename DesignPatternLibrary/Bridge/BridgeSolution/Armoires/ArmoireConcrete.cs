using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeProblem.Taille;

namespace BridgeProblem
{
    public class ArmoireConcrete : Armoire
    {
        public ArmoireConcrete(ITaille taille,IConstructeur constructeur) : base(taille,constructeur)
        {
        }

        public override void OuvrirPorte()
        {
            Console.WriteLine("L'amoire de taille : "+taille.DonneTaille()+ " de la marque: " + this.contructeur.Nom +" s'ouvre");
          
        }
    }
}
