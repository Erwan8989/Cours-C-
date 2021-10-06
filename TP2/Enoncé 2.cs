using System;

    namespace TP2
    {

        class Etudiant
        {
            private int note;
            private string nom;
            private string prenom;

            public string Student() // Constructeur vide
            {}

            public string Student(int age, string nom, string prenom)
            {
                age = Age; 
                nom = Nom; 
                prenom = Prenom;
            }
  
            // Création des getters

            public int get_age (int age) {
                return age;
            }

            public int get_nom (string nom) {
                return nom;
            }

            public int get_prenom (string prenom) {
                return prenom;
            }

            // Définiton des Setters

            public void set_age (int a) {
                this.age=a;
            }

            public void set_prenom (string p) {
                this.prenom=p;
            }

            public void set_nom (string n) {
                this.nom=n;
            }

        }

        class ClassWithMain
        {
            public static void Main()
            {

                Etudiant set_age = new Etudiant(age = 123);
                Etudiant set_prenom = new Etudiant(prenom = "Fluffy");
                Etudiant set_nom = new Etudiant(nom  = "Michel");
            }

        }           
}