using System;

namespace Cours_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "bonjour";
            Console.WriteLine("la taille de la chaine est " +s.Length);

            s = s.Replace('o', 'z');
            Console.WriteLine("la chaine devient : " +s);

            s = s.Insert(3, "-y-");
            Console.WriteLine("La chaine devient : " +s);

            if (s.Contains("ur")==true)
            {
                Console.WriteLine("La chaine contient ur");
            }

            if (s.Equals("bonjour") == false)
            {
                Console.WriteLine("La chaine n'égal pas à bonjour");
            }

            String m = s.Substring(0, 2);
            Console.WriteLine("Les deux premières lettres sont : " +m);
            Console.WriteLine("la chaine en majuscule : " +s.ToUpper());
            Console.WriteLine("La chaine en minuscule : " +s.ToLower());
        }
    }
}
