// using System;

// namespace Palindrome
// {
//       public class Palindrome {
  
//         public static void Main(string[] args)
//         {
           
//           string MyString, Reversed=""; 

//           Console.Write("S'il vous plaît, veuillez renseigner un mot : ");
//           MyString = (Console.ReadLine());

//           for (int i = MyString.Length - 1; i >= 0; i--)  // Initialisation d'une boucle pour avoir la taille de la chaine inversée.
//           {
//             Reversed = Reversed + MyString[i];
//           }    
          
//                   // Comparaison entre la taille du mot rentrée par l'utilisateur et la taille du mot inversé.
//           if(MyString == Reversed) {    
//             Console.Write("Le mot donnée est un Palindrome.\nLa chaîne entrée était {0} et la chaîne inversée est {1} ", MyString, Reversed);
//           }

//           else {
//           Console.Write("Le mot donnée n'est pas un Palindrome.\nLa chaîne entrée était {0} et la chaîne inversée est {1} ", MyString, Reversed);
//           }

//         }
//       }
// }

// int i = 0;  Valeur i à initialiser pour une condition while
// Cas pour une boucle while ! 
          // i = MyString.Length - 1;
          // while (i >= 0)
          // {
          //   Reversed = Reversed + MyString[i];
          //   i--;
          // } 


// **************************** Vérification d'un chiffre palindrome *****************************


// namespace Palindrome
// {
//       public class IsPalindrome
//   {
//         public static void Main(string[] args)
//         {
//           int chiffre ,total=0 ,valeur ,sum;

//           Console.Write("S'il vous plaît, veuillez renseigner un chiffre : ");
//           chiffre = int.Parse(Console.ReadLine());
//           valeur = chiffre;

//         while(chiffre > 0)
//         {
//           sum = chiffre % 10;
//           total = (total * 10) + sum;
//           chiffre = chiffre / 10;
//         }

//         if(valeur == total)
//            Console.Write("Le chiffre donnée est un Palindrome.");
//         else
//        Console.Write("Le chiffre donnée n'est pas un Palindrome.");
//       } 
//   }
// }


// ************************************************************************************************************************************************

// using System;

// namespace Palindrome
// {
//     class Demo 
    
//     {
//         static void Main() 
        
//         {
//           string Machaine, Reversed;
//           int longueur;

//           Machaine = "Tom";
//           Reversed ="";

//           Console.WriteLine("String is {0}", Machaine);
//           // find string length
          
//           longueur = Machaine.Length - 1;
          
//           while (longueur >= 0) 
//           {
//             Reversed = Reversed + Machaine[longueur];
//             longueur--;
//           }

//           Console.WriteLine("Reversed String is {0}", Reversed);
//           Console.ReadLine();
//         }
//     }
// }



// ************************************************************************************************************************************************


// using System;
// using System.Text;

// namespace Cours_C_
// {
//     class Program
//     {

//         // ********** Fonction qui permet de retourner une chaine de caractère entrée en paramètre **********

//         static string Inverse(string text)
//         {
//             // Copie des caractères de la chaine entrée, dans un tableau
//             char[] tab = text.ToCharArray();

//             //Inverse l'ordre des éléments contenu dans le tableau
//             Array.Reverse(tab);

//             // Retourne la copie des éléments contenu dans le tableau sous forme d'une chaine de caractère
//             return new string(tab);
//         }


//         static void Main(string[] args)
//         {
//             // Demande de saisie, et saisie d'une chaine de caractère par l'utilisateur
//             Console.WriteLine("Veuiller saisir un mot, je vous dirai s'il est palindrome");
//             string mot = Console.ReadLine();

//             // Permet de mettre le mot tout en minuscule. Cela évite d'obtenir un résulat faux en cas de majuscules entrées par l'utilisateur
//             mot = mot.ToLower();

//             // Création d'une chaine de caractère qui contiendra le résultat de la fonction "Inverse" après l'avoir appelée. 
//             string mot_inverse = Inverse(mot);


//             /* ********** Condition qui dit si le mot est palindrome. **********
            
//             Si la variable "mot" qui contient la chaine entrée par l'utilisateur est égale à "mot_inverse" qui contient le mot avec les ses caratères inversés, 
//             alors il s'agit de la définition d'un "mot palindrome". 
//             Sinon, le mot n'est pas palindrome */
            
//             if (mot == mot_inverse)
//                 Console.WriteLine("Ce mot est palindrome");
//             else
//                 Console.WriteLine("Ce mot n'est pas palindrome");
            
//         }
//     }
// }


