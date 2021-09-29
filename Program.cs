using System;
using System.Text;

namespace Cours_C_
{
    class Program
    {
       private static void Affiche(out string nom){ // ajouter out pour appel sans valeur initialisée
        nom="Titi";
       }
        

        static void Main(string[] args)
        {
            // Appel sans initialisation
        string Nombis = "test"; // coucou paramètre réel ou effectif
        //Console.WriteLine("Paramètre réel : "+Nombis);
        Affiche(out Nombis); // paramètre formel/réel modifiés, même paramètre
        Console.WriteLine("Paramètre réel : "+Nombis); // paramètre réel non modifié

        }
        
    }
}
