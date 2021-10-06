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

                Console.WriteLine(eleve1.get_prenom() + " " + eleve1.get_nom() + " " + eleve1.get_note());

            }

        }           
}