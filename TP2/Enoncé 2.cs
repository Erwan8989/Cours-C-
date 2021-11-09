using System;

    namespace TP2
    {

        class Etudiant
        {
            private int Note;
            private string Nom;
            private string Prenom;


            public Etudiant(int note, string nom, string prenom)
            {
                this.Note = note;
                this.Nom = nom;
                this.Prenom = prenom;                          
            }
  
//             // Création des getters

            public int get_note () {
                return this.Note;
            }

            public string get_nom () {
                return this.Nom;
            }

            public string get_prenom () {
                return this.Prenom;
            }

        }

        class ClassWithMain
        {
            public static void Main()
            {

                Etudiant eleve1 = new Etudiant(25, "Doe", "John" );

                // Console.WriteLine(eleve1.get_prenom() + " " + eleve1.get_nom() + " " + eleve1.get_note());

                int[]tab=initTableau();
                Etudiant eleve2 = new Etudiant(5, "oe", "Jhn" );
           
                for(int i = 0; i < tab.Length; i++){
                    i++;
                   
                    Console.WriteLine($"L'élève {i} du tableau s'appel {eleve1.get_prenom() + " " + eleve1.get_nom()} et a eu la note de {eleve1.get_note()}");
                    Console.WriteLine($"L'élève {i} du tableau s'appel {eleve2.get_prenom() + " " + eleve2.get_nom()} et a eu la note de {eleve2.get_note()}");
                } 


                static int[] initTableau(){

                Console.WriteLine("Entrer le nombre d'étudiant : ");
                int taille = int.Parse(Console.ReadLine());

                int [] tab1 = new int [taille];
                return tab1;
              
          }

                // Console.WriteLine(eleve1.get_prenom() + " " + eleve1.get_nom() + " " + eleve1.get_note());

            }

        }           
}