// using System;
// using System.Text;
// using System.Collections.Generic;

// namespace Cours_C_
// {
//     class Enonce3
//     {

//         static void Main(string[] args)
//         { 

            
            // ****************************** Enoncé 3 :  Traitement de tableaux  **************************************** //



            // 1. Donner la différence entre un tableau statique et un tableau dynamique

            // Les tableaux statiques reçoivent de la mémoire au moment de la compilation et la mémoire est allouée sur la pile. 
            // Alors que les tableaux dynamiques se voient allouer de la mémoire au moment de l'exécution et que la mémoire est allouée à partir du tas.

            // string [] users = new string[3] {"John","Doe","Pipe"};
            // Console.WriteLine (users);

      


            // 2. Définir un tableau d’entiers dynamique une dimension puis le trier selon l’ordre croissant.

            // int[] x = new int[]   { 12 ,25 ,3} ;
            // Array.Sort(x); // Fonction sort ordonne de manière croissante le code

            // foreach(int Value in x)
            // {
            // Console.WriteLine(Value);  
            // }
            // Console.WriteLine("Element at index [0, 0] : " + x[0,1].ToString);

            // }

            // 3. Définir un tableau deux dimensions d’entiers dynamique puis le trier.

        //     Console.Write ("Taille du tableau : ");
        //     int n = int.Parse(Console.ReadLine());

        //     // Déclaration + Initialisation

        //     double [] tab = new double[n];

        //     // Saisie 
        //     for (int i = 0; i < tab.Length; i++) {
        //         tab[i] = double.Parse (Console.ReadLine());
        //     }

        //     // Affichage 
        //     Console.WriteLine ("Les valeurs : ");
        //     foreach (double v in tab) {
        //         Console.WriteLine(v);
        //     }

        //     Console.WriteLine ("Press any key to continue ...");
        //     Console.ReadKey(true);
        // }


        // int [] tab = new int [];

        // for (int i = 0; i < tab.Length; i++) {
        //         tab[i] = int.Parse (Console.ReadLine()); }

            // int[,] x = new int [] {12 ,25 ,3};
            // Array.Sort(x); // Fonction sort ordonne de manière croissante le code

            // foreach(int Value in x)
            // {
            // Console.WriteLine(Value);  
            // }
            // Console.WriteLine("Element at index [0, 0] : " +x [0,1].ToString);

            // }


    // Création d'un tableau en 2D
    // string [][] noms = new string [2][];
    // for (int i = 0; i < noms.Length; i++) {
    //     noms[i] = new string [i + 1];
    //             // Console.WriteLine(noms [i]);
    //     }
    //         // Ouverture lier
    //         // Initialisation de la deuxième dimension 
    // for (int i = 0; i < noms.Length; i++) {
    //     for (int j = 0; j < noms[i].Length; j++) {
                        
    //         noms [i][j] = "Valeurs de l'élément : " + i + j;
    //         Console.WriteLine(noms [i][j]);
    //     }
    // }


// int[,] array2 = new int[,] {{1, 69, 54, 82, 856}, {203, 365, 5, 154 , 515}};
//              int k = 0, l = 0;

//             int rowLength = array2.GetLength(0);
//              int colLength = array2.GetLength(1);

//              Console.WriteLine("Tableau 2d : ");

//              Console.WriteLine("Desordre : ");

//              for( k = 0; k < rowLength; k++)
//                 {
//                  for( l = 0; l < colLength; l++)
//                  {
//                      Console.Write(array2[k,l] + " ");
//                  }
//                  Console.WriteLine(" ");
//              }


//              for(k = 0; k < rowLength; k++)
//              {
//                  for( l = 0; l < colLength; l++)
//                  {
//                      for(int m = l + 1; m < colLength; m++)
//                      {
//                          if(array2[k,l] > array2[k,m])
//                          {
//                              int temp = array2[k,l];
//                              array2[k,l] = array2[k,m];
//                              array2[k,m] = temp;
//                          }
//                      }
//                  }    
//                 }


//              Console.WriteLine(" ");

//              Console.WriteLine("Trier : ");

//              for( k = 0; k < rowLength; k++)
//              {
//                  for( l = 0; l < colLength; l++)
//                  {
//                      Console.Write(array2[k,l] + " ");
//                  }
//                  Console.WriteLine(" ");
//              }

//              Console.WriteLine(" ");

//              Console.WriteLine("La taille du tableau est de " + array.Length + " et il est de " + array.Rank+ " dimension");
//              Console.WriteLine("Le tableau est de " + array2.Rank + " dimension, sa taille est de R = " + rowLength + "  C = " + colLength);



//         }

//     }

// }
