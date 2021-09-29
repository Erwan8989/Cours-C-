// using System;
// using System.Text;
// using System.Collections.Generic;

// namespace Cours_C_
// {
//     class Enonce2
//     {

//         static void Main(string[] args)
//         { 

            
// ****************************** Enoncé 2 :  Traitement de chaînes de caractères  **************************************** //


        // 1. Afficher les deux chaînes concaténées en la chaîne S.

            // String S1 = "John";
            // String S2 = "Doe";

            // String s = S1 + "" +S2;
            // Console.WriteLine(a);

            // }

            // 2. Peut-on concaténer un entier N à S ?

            // string userName = "John";
            // string date = DateTime.Today.ToShortDateString();

            // // Use string interpolation to concatenate strings.
            // string str = $"Hello {userName}. Today is {date}.";
            // System.Console.WriteLine(str);

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

//         }

//     }

// }
