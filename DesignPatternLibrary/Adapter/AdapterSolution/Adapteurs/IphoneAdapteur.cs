using AdapterSolution.Chargeurs;
using AdapterSolution.Nouveau_Chargeur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSolution.Adapteurs
{
    public class IphoneAdapteur : IChargeurUniversel
    {

        private readonly IphoneChargeur _iphoneChargeur;
        public IphoneAdapteur(IphoneChargeur iphone)
        {
            this._iphoneChargeur = iphone;
        }


        public void Recharge()
        {
            this._iphoneChargeur.RechargeIphone();
        }
    }
}
