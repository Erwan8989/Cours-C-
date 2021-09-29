using System;

namespace tableau
{
    class Program
    {

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
           }          

         /* Console.WriteLine("Donner une taille au tableau ");
          int taille = int.Parse(Console.ReadLine());
          int transi;

          int [] tableau = new int [taille];
          for(int f = 0; f < tableau.Length; f++){
              Console.WriteLine("Saisir l'élément"+ f);
              tableau[f] = int.Parse(Console.ReadLine());
          }

           Console.WriteLine("test");

          for(int i = 0; i < tableau.Length; i++){
                      for(int j = 0 + i; j < taille - 1; j++){
                         if(tableau[j]<tableau[j + 1]){

                             transi = tableau[j];
                             tableau[j] = tableau[j + 1];
                             tableau[j + 1] = transi;
                         }
                      }

            Console.WriteLine(tableau[i]);
          }*/
           
        }
    }
}