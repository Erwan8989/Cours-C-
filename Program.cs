using System;
using System.Text;

namespace Cours_C_
{
    class Program
    {

        static void Main(string[] args)
        {


            // ************************************************** Entrer nom et prenom ************************************************
            /*
            //Saisie du prenom

            Console.WriteLine("Saisir votre nom");

            // string Nom = Console.ReadLine();
            
            Console.WriteLine("Votre nom est : {0} !", Nom);

            //Saisie du prenom

            string PNom = Saisir_PNom();
            Console.WriteLine("Votre prenom est " +PNom);

            Console.WriteLine("Vous vous nommez donc {0} {1}", PNom, Nom); 

             Afficher(Nom);
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



// ****************************** Enoncé 2 :  Traitement de chaînes de caractères  **************************************** //


        // 1. Afficher les deux chaînes concaténées en la chaîne S.

            // String S1 = "John";
            // String S2 = "Doe";

            // String s = S1 + "" +S2;
            // Console.WriteLine(a);

            // }

            // 2. Peut-on concaténer un entier N à S ?

            string userName = "John";
            string date = DateTime.Today.ToShortDateString();

            // Use string interpolation to concatenate strings.
            string str = $"Hello {userName}. Today is {date}.";
            System.Console.WriteLine(str);

            // string Name = "John";
            // int a = 15;

            // Console.WriteLine(a + "" + Name);

            // 3. Afficher la longueur de cette chaîne S.

            //  Console.WriteLine($"La taille de la chaine est de {s.Length} caractères");

            //  4. Afficher S en Majuscules puis en Minuscules.

            // Console.WriteLine("La chaine en majuscule : " +s.ToUpper());
            // Console.WriteLine("La chaine en majuscule : " +s.ToLower());

            // 5. Rechercher un caractère ou une sous chaîne spécifique dans S avec la 
            // méthode IndexOf en affichant le résultat.

            // Console.WriteLine(s.IndexOf("o"));  // Affiche la positon d'une lettre

            //          6. Extraire une sous chaîne de X caractères à partir de la position Y de S 
            //          avec la méthode Substring puis l’afficher

            // String x =s.Substring(0,2);
            // Console.WriteLine("Les deux premières lettres sont : " +x);

            //          7. Tester le code suivant et analyser les différentes comparaisons faites 
            //          entre deux chaînes :

            // String S1="Hello";
            // string S2="Hello!";

            // int N=string.Compare(S1,S2);                                // Compare deux objets String spécifiés et retourne un entier qui indique leur position relative dans l'ordre de tri.
            // Console.WriteLine("Résultat avec Compare :"+N);  

            // N=string.CompareOrdinal(S1,S2);
            // Console.WriteLine("Résultat avec CompareOrdinal :"+N);      // Compare deux objets String spécifiés en évaluant les valeurs numériques des objets Char correspondants dans chaque chaîne.

            // N=S1.CompareTo(S2);
            // Console.WriteLine("1ier Résultat avec CompareTo : "+N);      // Compare cette instance avec un Object spécifié et indique si cette instance précède, suit ou apparaît à la même position dans l'ordre de tri que le Object spécifié.

            // 9. Peut-on modifier une chaîne de caractères ? Quel est l’inconvénient ?

                        // char[] Tab=new char[]{'C','h','a','i','n','e'};
                        // string S=string.Empty;
                        // Console.WriteLine("Chaine S :"+S);

                        // foreach(var car in Tab)
                        // { S=S+car; // ou S+=car;
                        // Console.WriteLine("Chaine S :"+S);
                        // }


                        // // Version StringBuilder permet de modifier une chaine de caractère
                        // StringBuilder Sb=new StringBuilder();
                        // Console.WriteLine("Chaine Sb :"+Sb); 

                        // foreach(var car in Tab)
                        // { Sb.Append(car); // ou S+=car;b                      
                        // Console.WriteLine("Chaine Sb :"+Sb);
                        // }

                        // Sb.Insert(0,"Ma_");
                        // Console.WriteLine(Sb);

                        // Sb.Remove(2,1);
                        // Console.WriteLine(Sb);

                        // Sb.Replace('M', 'T');
                        // Console.WriteLine(Sb);

                        // Sb.AppendLine();
                        // Sb.Append("_Test");
                        // Console.WriteLine(Sb);

            

            // ****************************** Enoncé 3 :  Traitement de tableaux  **************************************** //



            // 1. Donner la différence entre un tableau statique et un tableau dynamique

            // Les tableaux statiques reçoivent de la mémoire au moment de la compilation et la mémoire est allouée sur la pile. 
            // Alors que les tableaux dynamiques se voient allouer de la mémoire au moment de l'exécution et que la mémoire est allouée à partir du tas.


            // 2. Définir un tableau d’entiers dynamique une dimension puis le trier selon l’ordre croissant.

            // int[] x = new int[]   { 1, 2 ,3} ;
            // Array.Sort(x); // Fonction sort ordonne de manière croissante le code

            // foreach(int Value in x)
            // {
            // Console.WriteLine(Value);  
            // }

            // Console.WriteLine("Element at index [0, 0] : " +x [0,0]);

            // }

            // 3. Définir un tableau deux dimensions d’entiers dynamique puis le trier.





            // ****************************** Enoncé 4 :  Testde conditionnelles/Switch/Boucles  **************************************** //



            // 1. Afficher chaque caractère de votre nom dans une boucle

            // Console.WriteLine("Saisir votre nom : ");
            // string Votre_Nom=Console.ReadLine();

            // foreach (char c in Votre_Nom)
            // {
            //     Console.WriteLine(c);
            // }

            // }
            // }

            // 2. Afficher les entiers compris entre 1 et 10 sans le 8.

            // for (int x = 0; x <= 10; x++) {
            //     if (x==8) 
            //     continue;
            //     else Console.WriteLine(); 
            // }


            // 3. Afficher les entiers de 0 à 15 par pas de 2.

            for(int x=0; x<=15;x+=2){
                // if(x%2 = 0) continue;
                /*else*/ Console.WriteLine(x);
            }



            // 4. Dans une boucle inviter l’utilisateur à saisir un prix HT (0 pour Terminer) et afficher sa valeur TTC.

            // string String_TVA;
            // Console.WriteLine("Saisir votre prix HT avec , 0 pour finir :");
            // float PHT=float.Parse(Console.ReadLine());

            // while (PHT > 0) {
            //     Console.WriteLine("Saisir le taux de TVA sans le % : ");

            //     String_TVA=Console.ReadLine();
            //     float TVA=float.Parse(String_TVA);

            //     float PTTC=PHT*(1+TVA/100);
            //     Console.WriteLine("Prix TTC : " +PTTC);
            //     Console.WriteLine("Saisir votre prix HT si vous voulez continuer sinon 0");
            //     PHT=float.Parse(Console.ReadLine());

            // }

            // 5. Ecrire un programme qui affiche la suite de symboles suivants :
            // * 
            // ** 
            // *** 
            // **** 
            // ***** 
            // ****** 
            // *******

// ****************************** Solution A **********************************    

            // StringBuilder etoile = new StringBuilder();
            // for (int v=1;v<6; v++) {
            //     etoile.Append("*");                         // Drop l'élément etoile
            //     Console.WriteLine(etoile.ToString());
            // }


// ****************************** Solution B **********************************  

    //     int val = 5;  
    //     int i, j, k ;  

    //     for (i = 1; i <= val; i++)  
    //     {  
    //         for (j = 1; j <= i; j++)  {  
    //            Console.Write("");  
    //         }  
    //         for (k = 1; k <= i; k++)  {  
    //            Console.Write("*");  
    //         }  
    //         Console.WriteLine("");  
    //      }  
    //      Console.ReadLine();  
    //   }

// ****************************** Solution C ********************************** 

            int b, c = 0;

            Console.WriteLine("Saisir une valeur");
            int a = int.Parse(Console.ReadLine());  

            for(b = 0; b < a;){
            Console.Write("*");
            c++;
                if (c == (a-b)){
                Console.WriteLine(""); 
                b++;
                c = 0;
                } 
            }
            Console.ReadLine();  }

    }
            
}





