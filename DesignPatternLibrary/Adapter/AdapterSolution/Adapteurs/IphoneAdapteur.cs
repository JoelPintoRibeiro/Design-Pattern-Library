using AdapterProblem.Chargeurs;
using AdapterProblem.Nouveau_Chargeur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblem.Adapteurs
{
    public class IphoneAdapteur : IChargeurUniverselle
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
