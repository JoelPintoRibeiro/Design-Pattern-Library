using AdapterSolution.Nouveau_Chargeur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSolution.Chargeurs
{
    public class SamsungChargeur : IChargeurUniversel
    {
        public void Recharge()
        {
            Console.Write("Le Samsung recharge");
        }
    }
}
