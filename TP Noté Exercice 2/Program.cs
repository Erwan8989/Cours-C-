using System;

namespace TP_Noté_Exercice_2
{

    class TabEtudiant
    {
        string [] tableauEtudiant; 

        public void initTableau(){ // Fonction qui initialise le tableau
            tableauEtudiant = new string [(Etudiant.getNbEtudiant()) +1]; // Le +1 permet d'ajouter une taille supplémentaire au tableau permettant d'associer la clé 1 pour l'élève1, et non pas 0 pour l'élève1. 
        }


       public void ajouter(Etudiant E){ // Fonction qui permet d'ajouter un étudiant au tableau
           initTableau();
           tableauEtudiant[Etudiant.getNbEtudiant()] = E.getPrenom();
       }

       public string getTableau(int id){ // Fonction qui permet de retourner le nom d'un étudiant selon sa clé dans le tableau
           return this.tableauEtudiant[id];
       }
    }

    class Etudiant : TabEtudiant // Classe fille Etudiant, qui hérite de Tab Etudiant
    {
        private string nomEtudiant;
        private string prenomEtudiant;
        private int noteEtudiant;
        public static int nbEtudiant = 0; // Méthode qui compte le nombre d'étudiant au total

        public Etudiant(string prenom, string nom, int note){ // Constructeur
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;
            this.noteEtudiant = note;
            nbEtudiant++; // Incrémente automatiquement, lors de l'instentiation de la classe le nombre total d'étudiant
        }

        public string getNom(){ // Fonction qui retourne le nom d'un étudiant
            return this.nomEtudiant;
        }

        public string getPrenom(){ // Fonction qui retourne le prénom d'un étudiant
            return this.prenomEtudiant;
        }

        public int getNote(){ // Fonction qui retourne la note d'un étudiant
            return this.noteEtudiant;
        }

        public static int getNbEtudiant(){ // Fonction qui retourne le nombre total d'étudiant
            return nbEtudiant;
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            Etudiant eleve1 = new Etudiant("John", "Doe", 18); // Instantiation de la classe étudiant avec l'objet eleve1

            Console.WriteLine("L'élève " + eleve1.getPrenom() + " " + eleve1.getNom() + " a eu " + eleve1.getNote() + " sur 20");

            eleve1.ajouter(eleve1); // Ajoute l'élève au tableau

            Console.WriteLine(eleve1.getTableau(1)); // Afficher son prenom depuis le tableau


            
            Etudiant eleve2 = new Etudiant("Pierre", "Durant", 20); // Instantiation de la classe étudiant avec l'objet eleve1 

            Console.WriteLine("L'élève " + eleve2.getPrenom() + " " + eleve2.getNom() + " a eu " + eleve2.getNote() + " sur 20");

            eleve2.ajouter(eleve2); // Ajoute l'élève au tableau

            Console.WriteLine(eleve2.getTableau(2)); // Afficher son prenom depuis le tableau

        }
    }

}
