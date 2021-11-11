using System;
using Compte_Bancaire;


 public class Program
    { 
        static void FirstAccount(string[] args)
        {
            // Scenario 1 :
            Console.WriteLine("Test Scenario Compte Bancaire :\n");    

            Compte CB1 = new Compte("Michel OBAMA",2339483,1000,0.11);

            // Affichage des détails du compte
            CB1.Affichage();

            // Elle décide de déposer 1000 euros
            CB1.depot(1000);

            CB1.Affichage();

            // Elle décide de retirer 2500 euros, mais n'a que 2000 euros sur son compte. Une erreur lui est retournée.
            CB1.retrait(2500);
            CB1.Affichage();

            // Arriver à la fin du mois, celui-ci est taxé de 5 euros
            CB1.Taxe();
            CB1.Affichage();
          
            // Elle décide de déposer 1500 euros, et touche ensuite des intérêts.
            CB1.depot(1500);
            CB1.TauxInteret();
            CB1.Affichage();
           
        }

    
        static void CompteCheque(string[] args)
        {
            // Scenario 2 :
            Console.WriteLine("Test Scenario Compte Cheque :\n");

            CompteCheque CC1 = new CompteCheque("Henri Poincaré",6747483,0,0.06);
            CC1.Affichage();
            CC1.depot(100);
            CC1.Affichage();
            CC1.depot(150);
            CC1.Affichage();
            CC1.retrait(50);
            CC1.Taxe();
            CC1.Affichage();
            // Son solde n'étant pas supérieur à 500 euros, il ne percevra pas d'intérêts
            CC1.TauxInteret();
            CC1.Affichage();
            CC1.depot(500);
            // Son solde étant maintenant supérieur à 500, il peut toucher des intérets
            CC1.TauxInteret();
            CC1.Affichage();
        }

        static void CompteLivret(string[] args)
        {
            // Scenario 3 :

            Console.WriteLine("Test Scenario Compte Livret :\n");

            CompteLivret CL1 = new CompteLivret("John DOE",547362,500,0.1);
            CL1.Affichage();
            CL1.depot(350);
            CL1.Affichage();
            CL1.retrait(750);
            // La solde de son compte étant inférieur à 200 euros, il se fait taxer au début du mois.
            CL1.Taxe();
            CL1.Affichage();
        }
    }

