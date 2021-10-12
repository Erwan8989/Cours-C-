using System;
namespace Lib
{
    // public class Class1
    // {
    //     // Fonctions simples
    //     public static int Somme(int a, int b)
    //     {
    //     return a + b;
    //     }
    //     public static int Produit(int a, int b)
    //     {
    //     return a * b;
    //     }
    // }
public class Calcules {
    public double CalculerMoyenne(double Math, double francais, double physique) {
        double moyenne;

        int c1 = 5, c2 = 7, c3 = 3;
        int total = c1 + c2 + c3;

        moyenne = (Math * c1 + physique * c2 + francais * c3) / total;

        return moyenne;

    }
}
}