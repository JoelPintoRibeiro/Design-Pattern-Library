using BridgeProblem.Taille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public abstract class Armoire
    {
        protected readonly ITaille taille;
        abstract public void OuvrirPorte();
        public Armoire(ITaille taille)
        {
            this.taille = taille;
        }
    }
}
