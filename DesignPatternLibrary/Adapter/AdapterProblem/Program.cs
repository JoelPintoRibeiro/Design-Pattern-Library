using AdapterProblem.Adapteurs;
using AdapterProblem.Chargeurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var iphoneChargeur = new IphoneChargeur();
            var monAdapteurIphone = new IphoneAdapteur(iphoneChargeur);
            monAdapteurIphone.Recharge();
            Console.ReadLine();
            

        }
    }
}
