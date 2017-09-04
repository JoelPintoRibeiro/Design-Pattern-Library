using AdapterSolution.Adapteurs;
using AdapterSolution.Chargeurs;
using AdapterSolution.Nouveau_Chargeur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSolution
{
    /// <summary>
    /// Notre entreprise a sorti un chargeur universel :
    /// Ce chargeur permet de recharger n'importe quel portable 
    /// qui implemente notre interface IChargeurUniversel
    /// </summary>
    /// 
    /// <problem>
    /// Apple a sorti un nouvel iphone , et ne veut pas implementer notre interface...
    /// C'est donc à nous de nous adapter à eux, mais comment faire ?
    /// </problem>
    class Program
    {
        static void Main(string[] args)
        {
            //Samsung
            IChargeurUniversel chargeurSamsung = new SamsungChargeur();
            chargeurSamsung.Recharge();

            //Iphone
            var iphoneChargeur = new IphoneChargeur();
            IChargeurUniversel chargeurIphone = new IphoneAdapteur(iphoneChargeur);
            chargeurIphone.Recharge();
            Console.ReadLine();
            

        }
    }
}
