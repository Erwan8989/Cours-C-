using System;
using System.Text;

namespace Cours_C_
{
    class Program
    {
        public static int[] creer(){

            Console.WriteLine("Veuillez saisir la taille d'un tableau");
            int taille = int.Parse(Console.ReadLine());
        
            while (taille <= 0 )
            {
                Console.WriteLine("Veuillez saisir la taille d'un tableau");
                taille = int.Parse(Console.ReadLine());
            }

            int[] tab = new int[taille];
            return tab;
        
        }
            
        public static int remplir(int taille){
            int[] tab = new int[taille];

            for (int i = 0; i < taille; i++)
            {
                Console.WriteLine("Veuillez entrer une valeur dans le tableau");
                tab[i] = int.Parse(Console.ReadLine());
            }
            return tab;
        }
        
        public static void trier(int[] tableau){
            int save;
            for (int i = 0; i < tableau.Length - 1; i++){
                for (int j = 0; j < tableau.Length - 1; j++){
                   
                    if (tableau[j] > tableau[j+1]){
                        save = tableau[j+1];
                        tableau[j+1] = tableau[j];
                        tableau[j] = save;
                    }
                }                
            }
        }

        public static void afficher(int[] tableau){
            foreach (int value in tableau){
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {
            int[] tableau = creer();

            remplir(tableau.length);

            trier(tableau);

            afficher(tableau);
            


            // int[,] tableau2 = {{2, 8}, {10, 0}, {20, 5}};
            
            // // Console.WriteLine(tableau2[2,1]);

            // // Array.Sort(tableau2);
            // int longueur2 = tableau2.Length;

            // for (int i = 0; i <= 2; i++){
            //     for (int j = 0; j < 1; j++){
            //         if (tableau2[i, j] > tableau2[i, j+1]){
            //             int save = tableau2[i, j+1];
            //             tableau2[i, j+1] = tableau2[i, j];
            //             tableau2[i, j] = save;
            //         }                    
                    
            //     }                          
            // } 

            // /* Correction Adam
            // for(k = 0; k < rowLength; k++)
            // {
            //     for( l = 0; l < colLength; l++)
            //     {
            //         for(int m = l + 1; m < colLength; m++)
            //         {
            //             if(array2[k,l] > array2[k,m])
            //             {
            //                 int temp = array2[k,l];
            //                 array2[k,l] = array2[k,m];
            //                 array2[k,m] = temp;
            //             }
            //         }
            //     }
            // }
            // */

            // foreach (int value in tableau2)
            // {
            //     Console.WriteLine(value);
            // }

            // Console.WriteLine("La longueur du tableau a deux dimension est de " +tableau2.Length);
            // Console.WriteLine("Il s'agit d'un tableau à " +tableau2.Rank+ " dimension(s)");
            
        }
        
    }
}
