// using System;
// using System.Text;

// namespace Cours_C_
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {/*
//             String S1 = "Chaine 1";
//             String S2 = "Chaine 2";

//             String S = S1 + S2;
//             Console.WriteLine(S);
//             // String S = S1 + S2 + 5; On ne peut pas cancaténer un entier à S vu qu'il s'agit d'un string 

//             Console.WriteLine(S.Length);

//             Console.WriteLine(S.ToUpper());
//             Console.WriteLine(S.ToLower());

        
//             Console.WriteLine(S.IndexOf("Chaine"));

//             String m = S.Substring(2, 6);
//             Console.WriteLine(m);
//             */


//             /*
//             string S1="Hello";
//             string S2="Hello!";

//             // Compare deux objets string et renvoie un entier qui indique la position relative dans l'ordre de trie
//             int N=string.Compare(S1,S2);
//             Console.WriteLine("Résultat avec Compare :"+N);

//             // Compare deux objets string en évaluant la valeur numérique des valeurs char
//             N=string.CompareOrdinal(S1,S2);
//             Console.WriteLine("Résultat avec CompareOrdinal :"+N);

//             // Compare l'instance avec un string et renvoie une valeur qui indique si cette instance précède, suit ou apparait à la même position suivant l'ordre de trie. 
//             N=S1.CompareTo(S2);
//             Console.WriteLine("1ier Résultat avec CompareTo : "+N);

//             */

//             char[] Tab=new char[]{'C','h','a','i','n','e'};
//             string S=string.Empty;
//             Console.WriteLine("Chaine S :"+S);

//             foreach(var car in Tab)
//             { S=S+car; // ou S+=car;
//             Console.WriteLine("Chaine S :"+S);

//             }
//             Console.WriteLine("Chaine S :"+S);
//             // Version StringBuilder
//             StringBuilder Sb=new StringBuilder();
//             Console.WriteLine("Chaine Sb :"+Sb);

//             foreach(var car in Tab)
//             { Sb.Append(car); // ou S+=car;b
//             Console.WriteLine("Chaine Sb :"+Sb);

//             }
//             Console.WriteLine("Chaine Sb :"+Sb);
//             Sb.Insert(0,"Ma_");
//             Console.WriteLine(Sb);
//             Sb.Remove(2,1);
//             Console.WriteLine(Sb);
//             Sb.Replace('M', 'T');
//             Console.WriteLine(Sb);
//             Sb.AppendLine();
//             Sb.Append("_Test");
//             Console.WriteLine(Sb);

//         }
//     }
// }
