using BridgeProblem.Taille;
using System;

namespace BridgeProblem
{
    internal class Program
    {
        // On souhaite avoir 3 tailles differentes par armoire en plus (enorme grande et petite)
        // Notre developpeur junior à commencé à créer 3 sous classes par Armoire avec les 3 tailles differents
        // Mais notre architecte a entendu parler d'un design pattern qui permettrait de factoriser ce code
        // et ainsi d'eviter d'avoir à creer 3 classes par armoire...
        //Le but sera de supprimer le dossier ArmoiresSupplementaires et trouver un autre moyen de definir la taille d'une armoire
        private static void Main(string[] args)
        {

            var PetiteTaille = new PetiteCapacite();

            var monArmoireIkea = new ArmoireIkea(PetiteTaille);

            monArmoireIkea.OuvrirPorte();

            var GrandeTaille = new GrandeCapacite();
            var maGrandeArmoireCasto = new ArmoireCastorama(GrandeTaille);
            maGrandeArmoireCasto.OuvrirPorte();

            Console.ReadLine();
        }
    }
}