using System;

namespace Méthode
{
    class Program
    {
       static double Convertion(int a){

           return a * 1.17;
       }

        static void Main(string[] args)
        {
             int[] Euro = {1,2,3,500,1200};
             double[] Dollar = new double[Euro.Length];
             int indenf;
             
             for(int i = 0;i < Euro.Length; i++){
                 
                 Dollar[i] = Convertion(Euro[i]);
                 Console.WriteLine($"{Euro[i]} Euro est égale à {Dollar[i]} dollar.");
             }

        }
    }
}
