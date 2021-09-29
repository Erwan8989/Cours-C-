// using System;
// using System.Text;
// using System.Collections.Generic;

// namespace Cours_C_
// {
//     class Enonce4
//     {

//         static void Main(string[] args)
//         { 

            
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

            // for(int x=0; x<=15;x+=2){
            //     // if(x%2 = 0) continue;
            //     /*else*/ Console.WriteLine(x);
            // }



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

    //         int b, c = 0;

    //         Console.WriteLine("Saisir une valeur");
    //         int a = int.Parse(Console.ReadLine());  

    //         for(b = 0; b < a;){
    //         Console.Write("*");
    //         c++;
    //             if (c == (a-b)){
    //             Console.WriteLine(""); 
    //             b++;
    //             c = 0;
    //             } 
    //         }
    //         Console.ReadLine();  }

    

// **************************

                // decimal[ , ] tabVentes = new decimal [4, 6]; //4 rangées et 6 colonnes

                // //---- Remplir le tableau des ventes --------------------------------
                // for (int rangee= 0; rangee < tabVentes.GetLength(0); rangee ++)
                // {
                // for (int colonne = 0; colonne < tabVentes.GetLength(1); colonne++)
                // {
                //     tabVentes[rangee, colonne] = (colonne + 1) * (rangee + 1 ) * 10;
                //     Console.Write(tabVentes[rangee, colonne] + ":");
                // }
                // Console.WriteLine();
                // }
                // //--- Calculer la moyenne des ventes -------------------------------
                // decimal accVentes = 0;
                // foreach (decimal uneVente in tabVentes)
                // {
                // accVentes += uneVente;
                // }
                // decimal moyenne = accVentes / tabVentes.Length;
                // Console.WriteLine("moyenne = " + moyenne); 

//         }

//     }

// }
