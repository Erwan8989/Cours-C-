// using System;

// namespace Cours_C_
// {
//     class Program
//     {

//         static void Main(string[] args)
//         {


//             // ******************************* Enoncé 1, question 6 ******************************
            
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

            

//             // ****************************** Enoncé 1, question 7 **************************************************
            
//             // Conversion d'un double vers un short
//             Console.WriteLine("");
//             Console.WriteLine("Conversion d'un double vers un short");
//             Console.WriteLine("");

//             Console.WriteLine("Entrez un nombre flotant");
//             double nb_float = double.Parse(Console.ReadLine());
//             short nb_short = (short)nb_float;

//             Console.WriteLine("Le nombre flotant de type double que vous avez entré {0}, converti en type short donne {1}", nb_float, nb_short);

//             // Conversion d'un int vers un sbyte
//             Console.WriteLine("");
//             Console.WriteLine("Conversion d'un int vers un sbyte");
//             Console.WriteLine("");

//             Console.WriteLine("Entrez un nombre entier");
//             int nb_int = int.Parse(Console.ReadLine());
//             sbyte nb_sbyte = (sbyte)nb_int;

//             // Condition qui explique pourquoi la conversion pourrait avoir un résulat innatendu
//             if (nb_int > 127 || nb_int < -128)
//             {   
//                 Console.WriteLine("Le nombre entier de type int que vous avez entré {0}, converti en type sbyte donne {1}", nb_int, nb_sbyte);
//                 Console.WriteLine("La valeur du sbyte est différente du int car un sbyte ne peut qu'avoir une valeur comprise entre -128 et 127");
//             }
//             else
//             {
//                 Console.WriteLine("Le nombre entier de type int que vous avez entré {0}, converti en type sbyte donne {1}", nb_int, nb_sbyte);
//             }

//             // Conversion d'un int vers un ushort
//             Console.WriteLine("");
//             Console.WriteLine("Conversion d'un int vers un ushort");
//             Console.WriteLine("");

//             Console.WriteLine("Entrez un nombre entier");
//             int nb_int2 = int.Parse(Console.ReadLine());
//             ushort nb_ushort = (ushort)nb_int2;

//             // Condition qui explique pourquoi la conversion pourrait avoir un résulat innatendu
//             if (nb_int2 < 0 || nb_int2 > 65535)
//             {   
//                 Console.WriteLine("Le nombre entier de type short que vous avez entré {0}, converti en type ushort donne {1}", nb_int2, nb_ushort);
//                 Console.WriteLine("La valeur du short est différente du ushort car un ushort ne peut qu'avoir une valeur comprise entre 0 et 65535");
//             }
//             else
//             {
//                 Console.WriteLine("Le nombre entier de type int que vous avez entré {0}, converti en type sbyte donne {1}", nb_int2, nb_ushort);
//             }


//         }

//         static bool Egalite(int x, int y){
//             if (x == y)
//                 return true;

//             else
//                 return false;
            
//         }
//     }
// }
