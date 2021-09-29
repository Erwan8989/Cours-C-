using System;
using System.Text;
using System.Collections.Generic;

namespace Cours_C_
{
    class Enonce5
    {

        private static string Concaténer(string x, string y) { // static : méthode unique non liée à un objet 
        return x + y; }

        static void Main(string[] args)
        { 

             // Appel de la fonction concaténer
            string w=Concaténer("Mes ","Etudiants");
            Console.WriteLine("concaténation : " + w);

            // ou bien
            string x="Etudiants ";
            string y="EPSI!!!";
            Console.WriteLine("Concaténation de deux chaines : "+Concaténer(x, y)); 

        }
    }

}
     