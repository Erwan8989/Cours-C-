using System;

namespace TP_Noté_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant eleve1 = new Etudiant("John", "Doe", 18);

            Console.WriteLine("L'élève " + eleve1.getPrenom() + " " + eleve1.getNom() + " a eu " + eleve1.getNote() + " sur 20");
            
        }
    }

    class Etudiant
    {
        private string nomEtudiant;
        private string prenomEtudiant;
        private int noteEtudiant;

        public Etudiant(string prenom, string nom, int note){
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;
            this.noteEtudiant = note;
        }

        public string getNom(){
            return this.nomEtudiant;
        }

        public string getPrenom(){
            return this.prenomEtudiant;
        }

        public int getNote(){
            return this.noteEtudiant;
        }
    }
}
