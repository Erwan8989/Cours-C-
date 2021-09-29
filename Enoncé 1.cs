// using System;
// using System.Text;
// using System.Collections.Generic;

// namespace Cours_C_
// {
//     class Program
//     {

//         static void Main(string[] args)
//         { 

            // ************************************************** Entrer nom et prenom ************************************************
            /*
            //Saisie du prenom

            Console.WriteLine("Saisir votre nom");
            string Nom = Console.ReadLine();
            Console.WriteLine("Votre nom est : {0} !", Nom);

            // Saisie du prenom

            Console.WriteLine("Saisir votre Prenom");
            string PNom = Console.ReadLine();
            Console.WriteLine("Votre prenom est " +PNom);

            Console.WriteLine("Vous vous nommez donc {0} {1}", PNom, Nom); 

           */
            

            // ******************************* Comparer deux valeurs ************************************

            /*
            Console.WriteLine("Entrez une valeur");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez une valeur");
            int c = int.Parse(Console.ReadLine());
            
            int a = Maximum(b, c);
            Console.WriteLine("Le maximum est " +a);

            bool Result = Egalite(b, c);
            Console.WriteLine("Le resultat du booléen est " +Result);
            */
            
            // ************************************************ Case : Break ************************************

            /*
            Console.WriteLine("Saisir numéro professionnel ");
            int telephone = int.Parse(Console.ReadLine());

            switch (telephone)
            {
                case 15:
                Console.WriteLine("Numero du Samu");
                break;
                case 17:
                Console.WriteLine("Numero de la police");
                break;
                case 18:
                Console.WriteLine("Numero des pompiers");
                break;
                default:
                Console.WriteLine("Numero inconnu");
                break;
            }
            */

            // for (int a = 0; a < 10; a++)
            // {
            //     Console.WriteLine("Iteration numero " +a);
            //     int test = a % 50 == 0 ? 1 : 2;
                /*
                Equivaut à :
                int test
                if (a%50 == 0)
                    test = 2
                else
                    test = 1 
                */

        //         Console.WriteLine("test : " +test);
        //     }
        // }

        //méthode (fonction) qui renvoie le prenom ou par parametres

        // static string Saisir_PNom(){    
        //     Console.WriteLine("Saisir votre prenom");
        //     string PName = Console.ReadLine();
        //     return PName;
        // }

        // Procédure affichage 

        // static void Afficher(int x){
        //     Console.WriteLine(x);
        // }

        // methode qui renvoie un entier

        // static int Maximum(int x, int y){
        //     if (x > y)
        //     {
        //         return x;
                
        //     }
        //     else
        //     {
        //         return y;
        //     }
        // }   

        // methode qui renvoie un booléen

    //     static bool Egalite(int x, int y){
    //         if (x == y)
    //             return true;

    //         else
    //             return false;
            
    //     }
    // }

      // ******************************* Enoncé 1, question 6 ******************************
            
//             Console.WriteLine("Entrez une valeur de type int");
//             int a = int.Parse(Console.ReadLine());
//             Console.WriteLine("Le type et la taille de la variable a est : ");
//             Console.WriteLine(a.GetType());  

//             Console.WriteLine("Entrez une seconde valeur de type int");
//             int b = int.Parse(Console.ReadLine());
//             Console.WriteLine("Le type et la taille de la variable b est : ");
//             Console.WriteLine(b.GetType());  

//             bool Result = Egalite(a, b);
//             Console.WriteLine("Si les deux valeurs précédentes sont égales, alors le booléen vaudra true. Résulat : " +Result);
//             Console.WriteLine("Le type et la taille de la variable Result est : ");
//             Console.WriteLine(Result.GetType());  

//         }

//         private static bool Egalite(int a, int b)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }

            

//             // ****************************** Enoncé 1, question 7 **************************************************
            
            // Conversion d'un double vers un short
            // Console.WriteLine("");
            // Console.WriteLine("Conversion d'un double vers un short");
            // Console.WriteLine("");

            // Console.WriteLine("Entrez un nombre flotant");
            // double nb_float = double.Parse(Console.ReadLine());
            // short nb_short = (short)nb_float;

            // Console.WriteLine($"Le nombre flotant de type double que vous avez entré {nb_float}, converti en type short donne {nb_short}");

    //         // Conversion d'un int vers un sbyte
    //         Console.WriteLine("");
    //         Console.WriteLine("Conversion d'un int vers un sbyte");
    //         Console.WriteLine("");

    //         Console.WriteLine("Entrez un nombre entier");
    //         int nb_int = int.Parse(Console.ReadLine());
    //         sbyte nb_sbyte = (sbyte)nb_int;

    //         if (nb_int > 127 || nb_int < -128)
    //         {   
    //             Console.WriteLine("Le nombre entier de type int que vous avez entré {0}, converti en type sbyte donne {1}", nb_int, nb_sbyte);
    //             Console.WriteLine("La valeur du sbyte est différente du int car un sbyte ne peut qu'avoir une valeur comprise entre -128 et 127");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Le nombre entier de type int que vous avez entré {0}, converti en type sbyte donne {1}", nb_int, nb_sbyte);
    //         }

    //         // Conversion d'un int vers un ushort
    //         Console.WriteLine("");
    //         Console.WriteLine("Conversion d'un int vers un ushort");
    //         Console.WriteLine("");

    //         Console.WriteLine("Entrez un nombre entier");
    //         int nb_int2 = int.Parse(Console.ReadLine());
    //         ushort nb_ushort = (ushort)nb_int2;

    //         if (nb_int2 < 0 || nb_int2 > 65535)
    //         {   
    //             Console.WriteLine("Le nombre entier de type short que vous avez entré {0}, converti en type ushort donne {1}", nb_int2, nb_ushort);
    //             Console.WriteLine("La valeur du short est différente du ushort car un ushort ne peut qu'avoir une valeur comprise entre 0 et 65535");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Le nombre entier de type int que vous avez entré {0}, converti en type sbyte donne {1}", nb_int2, nb_ushort);
    //         }


    //     }

    //     static bool Egalite(int x, int y){
    //         if (x == y)
    //             return true;

    //         else
    //             return false;
            
    //     }
    // }

    // ******************************* Comparer de valeurs grâce aux méthodes Replace, Insert & Substring ************************************

    // String s = "bonjour";
    // Console.WriteLine($"La taille de la chaine est de {s.Length} caractères");

    // s=s.Replace("O","Z");
    // Console.WriteLine("La chaine devient : " +s);

    // s=s.Insert(3,"-y-");
    // Console.WriteLine("La chaine devient : " +s);
    // if (s.Contains("ur")==true)
    // Console.WriteLine("La chaine contient ur");
    
    // if (s.Equals("Bonjour")==false)
    // Console.WriteLine("La chaine n'est pas égale à bonjour");

    // String m =s.Substring(0,2);
    // Console.WriteLine("Les deux premières lettres sont : " +m);
    // Console.WriteLine("La chaine en majuscule : " +s.ToUpper());
    // Console.WriteLine("La chaine en majuscule : " +s.ToLower());

            

            


