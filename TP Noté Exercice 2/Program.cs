using System;

namespace TP_Noté_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant eleve1 = new Etudiant("John", "Doe", 18); // instanciation de la classe Etudiant, en passant en paramètre le nom, le prénom et la note

            Console.WriteLine("L'élève " + eleve1.getPrenom() + " " + eleve1.getNom() + " a eu " + eleve1.getNote() + " sur 20"); // Appel de méthodes de la classe Etudiant pour afficher le nom, prenom et la note
            
        }
    }

    class Etudiant
    {   
        // Création des attributs de la classe
        private string nomEtudiant;
        private string prenomEtudiant;
        private int noteEtudiant;

        public Etudiant(string prenom, string nom, int note){ // Constructeur
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;
            this.noteEtudiant = note;
        }

        public string getNom(){ // création de la méthode getNom pour afficher le nom
            return this.nomEtudiant;
        }

        public string getPrenom(){ // création de la méthode getPrenom pour afficher le prenom
            return this.prenomEtudiant;
        }

        public int getNote(){ // création de la méthode getNote pour afficher la note
            return this.noteEtudiant;
        }
    }
}
