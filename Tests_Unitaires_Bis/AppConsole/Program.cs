using System;
using RessourcesLib;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("Hello World");


        Services Salle1=new Services(15);
        Salle1.Afficher_Ressources();
        Salle1.PriseRessources(2);
        Salle1.Afficher_Ressources();
        Salle1.PriseRessources(13);
        Salle1.Afficher_Ressources();  
        Salle1.PriseRessources(1);
        Salle1.RendreRessources(15);
        Salle1.Afficher_Ressources();

        Services Salle_Apple=new Services(10);
        Salle_Apple.Afficher_Ressources();
         

        Console.WriteLine("NBR Ressources libres:Salle1.get_NbRessourcesLibres()");    
        
        }
    }
}
