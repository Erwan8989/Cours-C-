using System;

    namespace TP2
    {

        class Etudiant
        {
            private int Note;
            private string Nom;
            private string Prenom;

            public string Student() // Constructeur vide
            {}

            public void Student(int note, string nom, string prenom)
            {
                this.Note = note;
                this.Nom = nom;
                this.Prenom = prenom;
                          
            }
  
            // Création des getters

            public int get_note () {
                return Note;
            }

            public int get_nom () {
                return Nom;
            }

            public int get_prenom () {
                return Prenom;
            }

            // Définiton des Setters

            public void set_note (int a) {
                this.Note=a;
            }

            public void set_prenom (string p) {
                this.Prenom=p;
            }

            public void set_nom (string n) {
                this.Nom=n;
            }

        }

        class ClassWithMain
        {
            public static void Main()
            {

                Etudiant eleve1 = new Etudiant(25, "Doe", "John" );

                Console.WriteLine(eleve1.get_prenom() + " " + eleve1.get_nom() + " " + eleve1.get_note());


                // Etudiant set_note = new Etudiant(Note = 123);
                // Etudiant set_prenom = new Etudiant(Prenom = "Fluffy");
                // Etudiant set_nom = new Etudiant(Nom  = "Michel");


            }

        }           
}