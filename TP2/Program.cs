using System;

namespace TP2
{
    class Program
    {
//         public static void trier(int[] tableau){
//             int save;
//             for (int i = 0; i < tableau.Length - 1; i++){
//                 for (int j = 0; j < tableau.Length - 1; j++){  
//                     if (tableau[j] > tableau[j+1]){
//                         save = tableau[j+1];
//                         tableau[j+1] = tableau[j];
//                         tableau[j] = save;
//                     }
//                 }                
//             }
//         }

//         public static void afficher(int[] tableau){
//             foreach (int value in tableau){
//                 Console.WriteLine(value);
//             }
//         }
//         static void Main(string[] args)
//         {
//             int[] tableau = new int[] {2, 8, 7, 54, 10, 0};
//             trier(tableau);
//             afficher(tableau);
            
//         }
//     }
// }

// static void Main(string[] args) {

//         int[] tableau = new int[] {2, 8, 7, 54, 10, 0};

//         int save;
//             for (int i = 0; i < tableau.Length - 1; i++){
//                 for (int j = 0; j < tableau.Length - 1; j++){
                   
//                     if (tableau[j] > tableau[j+1]){
//                         save = tableau[j+1];
//                         tableau[j+1] = tableau[j];
//                         tableau[j] = save;
//                     }
//                 }                
//             }
        

//           foreach (int value in tableau){
//                 Console.WriteLine(value);
//             }
//         }

// *************    Méthode pour un tableau static ***************
static int[] initTableau(){

              Console.WriteLine("Entrer la taille du tableau");
              int taille = int.Parse(Console.ReadLine());
              int [] tab1 = new int [taille];
              return tab1;
              
          }
        static void Main(string[] args)
        {
                      
           int[]tab=initTableau();
           
           for(int i = 0; i < tab.Length; i++){

               tab[i] = i;
               Console.WriteLine($"la case {i} du tableau contient une valeur de {tab[i]}");
           }    }
    }
}




// TEST UNITAIRE : permet de tester un bout de code isolé.