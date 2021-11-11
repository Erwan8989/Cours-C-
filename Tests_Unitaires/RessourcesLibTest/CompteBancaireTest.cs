using System;
using Xunit;

namespace RessourcesLibTest
{
     public class Program
    {

        [Test]
        static void FirstAccount(string[] args)
        {

            // Scenario 1 :
            Console.WriteLine("Test Scenario Compte Bancaire :\n");    

            Compte CB1 = new Compte("Michel OBAMA",2339483,20000,0.11);
            CB1.Affichage();
            CB1.depot(0);
            CB1.Affichage();
            CB1.retrait(0);
            CB1.Affichage();
            CB1.Taxe();
            CB1.Affichage();
            CB1.depot(0);
            CB1.Affichage();
            CB1.TauxInteret();
            CB1.Affichage();
            CB1.retrait(0); 

        }

        [Test]
        static void CompteCheque(string[] args)
        {
            // Scenario 2 :
            Console.WriteLine("Test Scenario Compte Cheque :\n");

            CompteCheque CC1 = new CompteCheque("Nathalie EPSI",6747483,0,0.06);
            CC1.Affichage();
            CC1.depot(0);
            CC1.Affichage();
            CC1.depot(0);
            CC1.Affichage();
            CC1.retrait(0);
            CC1.Taxe();
            CC1.Affichage();
            CC1.TauxInteret();
            CC1.Affichage();
            CC1.depot(0);
            CC1.TauxInteret();
            CC1.Affichage();
        }

        [Test]
        static void CompteLivret(string[] args)
        {
            // Scenario 3 :

            Console.WriteLine("Test Scenario Compte Livret :\n");

            CompteLivret CL1 = new CompteLivret("John DOE",547362,0,0.1);
            CL1.Affichage();
            CL1.depot(0);
            CL1.Affichage();
            CL1.retrait(0);
            CL1.Taxe();
            CL1.TauxInteret();
            CL1.Affichage();
            CL1.depot(0);
            CL1.Taxe();
            CL1.Affichage();
        }
    }
}
