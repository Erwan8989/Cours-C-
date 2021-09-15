using System;

namespace Cours_C_
{
    class Program
    {

        static void Main(string[] args)
        {

            // ************************************************** Entrer nom et prenom ************************************************
            /*
            //Saisie du prenom

            Console.WriteLine("Saisir votre nom");

            // string Nom = Console.ReadLine();
            
            Console.WriteLine("Votre nom est : {0} !", Nom);

            //Saisie du prenom

            string PNom = Saisir_PNom();
            Console.WriteLine("Votre prenom est " +PNom);

            Console.WriteLine("Vous vous nommez donc {0} {1}", PNom, Nom); 

             Afficher(Nom);
            */

            // ******************************* Comparer deux valeurs ************************************

            /*
            Console.WriteLine("Entrez une valeur");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez une valeur");
            int c = int.Parse(Console.ReadLine());
            
            int a = Maximum(b, c);
            Console.WriteLine("Le maximum est " +a);

            bool Result = Egalite(b, c);
            Console.WriteLine("Le resulstat du booléen est " +Result);
            */
            
            // ************************************************ Entrer numéro professionnel ************************************

            /*
            Console.WriteLine("Saisir numéro professionnel ");
            int telephone = int.Parse(Console.ReadLine());

            switch (telephone)
            {
                case 15:
                Console.WriteLine("Numero du Samu");
                break;
                case 17:
                Console.WriteLine("Numero de la police");
                break;
                case 18:
                Console.WriteLine("Numero des pompiers");
                break;
                default:
                Console.WriteLine("Numero inconnu");
                break;
            }
            */

            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Iteration numero " +a);
                int test = a % 50 == 0 ? 1 : 2;
                /*
                Equivaut à :
                int test
                if (a%50 == 0)
                    test = 2
                else
                    test = 1
                */

                Console.WriteLine("test : " +test);
            }
        }

        //méthode (fonction) qui renvoie le prenom ou par parametres

        static string Saisir_PNom(){    
            Console.WriteLine("Saisir votre prenom");
            string PName = Console.ReadLine();
            return PName;
        }

        // Procédure affichage 

        static void Afficher(int x){
            Console.WriteLine(x);
        }

        // methode qui renvoie un entier

        static int Maximum(int x, int y){
            if (x > y)
            {
                return x;
                
            }
            else
            {
                return y;
            }
        }   

        // methode qui renvoie un booléen

        static bool Egalite(int x, int y){
            if (x == y)
                return true;

            else
                return false;
            
        }
    }
}
