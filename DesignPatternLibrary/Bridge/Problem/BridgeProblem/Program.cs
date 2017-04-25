using System;

namespace BridgeProblem
{
    internal class Program
    {
        // On souhaite avoir 3 tailles differentes par armoire en plus (enorme grande et petite)
        // Notre developpeur junior à commencé à créer 3 sous classes par Armoire avec les 3 tailles differents
        // Mais notre architecte a entendu parler d'un design pattern qui permettrait de factoriser ce code
        // et ainsi eviter d'avoir à creer 3 classes par armoire...
        //Le but sera de supprimer le dossier ArmoiresSupplementaires et trouver un autre moyen de definir la taille d'une armoire
        //ceci pour eviter dans l'avenir de se retrouver avec une multiplication inutile de classe...
        private static void Main(string[] args)
        {
            var monArmoireIka = new ArmoireIkea();

            monArmoireIka.OuvrirPorte();

            var maGrandeArmoireCasto = new ArmoireCastoramaGrande();
            maGrandeArmoireCasto.OuvrirPorte();

            Console.ReadLine();
        }
    }
}