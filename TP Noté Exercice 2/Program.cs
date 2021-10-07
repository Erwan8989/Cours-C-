using System;

namespace TP_Noté_Exercice_2
{

    class TabEtudiant
    {
        static string [,] tableauEtudiant = tableauEtudiant = new string [31,3]; //Créatin du tableau en static afin d'avoir un tableau commun à tous les objets
        public TabEtudiant(){}

        

        // public void initTableau(){ // Fonction qui initialise le tableau
            
        // }


       public static void ajouter(Etudiant E){ // Fonction qui permet d'ajouter un étudiant au tableau avec son nom, prenom et note
           tableauEtudiant[Etudiant.getNbEtudiant(),0] = E.getPrenom();
           tableauEtudiant[Etudiant.getNbEtudiant(),1] = E.getNom();
           tableauEtudiant[Etudiant.getNbEtudiant(),2] = (E.getNote()).ToString();
           
       }

       public void getTableauAll(int id){ // Fonction qui permet de retourner toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
           for (int i = 0; i <= 2; i++)
           {
               Console.WriteLine(tableauEtudiant[id, i]);
           }
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

            TabEtudiant.ajouter(eleve1); // Ajoute l'élève au tableau

            eleve1.getTableauAll(1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau      


            
            Etudiant eleve2 = new Etudiant("Pierre", "Durant", 20); // Instantiation de la classe étudiant avec l'objet eleve1 

            Console.WriteLine("L'élève " + eleve2.getPrenom() + " " + eleve2.getNom() + " a eu " + eleve2.getNote() + " sur 20");

            TabEtudiant.ajouter(eleve2); // Ajoute l'élève au tableau

            eleve2.getTableauAll(2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau        

        }
    }

}
