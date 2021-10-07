using System;

namespace TP_Noté_Exercice_2
{

    class TabEtudiant
    {
        static string [,] tableauEtudiant = tableauEtudiant = new string [30,3]; //Création du tableau en static afin d'avoir un tableau commun à tous les objets
        public TabEtudiant(){}

        

        // public void initTableau(){ // Fonction qui initialise le tableau
            
        // }


       public static void ajouter(Etudiant E){ // Fonction qui permet d'ajouter un étudiant au tableau avec son nom, prenom et note
           tableauEtudiant[E.getIdEtudiant(),0] = E.getPrenom();
           tableauEtudiant[E.getIdEtudiant(),1] = E.getNom();
           tableauEtudiant[E.getIdEtudiant(),2] = (E.getNote()).ToString();
       }

       public void getTableauAll(Etudiant E){ // Fonction qui permet de retourner toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
            int id = E.getIdEtudiant(); // Récupération de l'ID de l'étudiant pour l'identifier dans le tableau
            Console.WriteLine("L'étudiant avec l'ID " + id + " s'appelle " + tableauEtudiant[id, 0] + " " + tableauEtudiant[id, 1] + " et a comme note : " + tableauEtudiant[id, 2] + "/20");
           
       }
    }

    class Etudiant : TabEtudiant // Classe fille Etudiant, qui hérite de Tab Etudiant
    {
        private string nomEtudiant;
        private string prenomEtudiant;
        private int noteEtudiant;
        public static int nbEtudiant = 0; // Méthode qui compte le nombre d'étudiant au total
        private int idEtudiant;

        public Etudiant(string prenom, string nom, int note){ // Constructeur
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;
            this.noteEtudiant = note;
            nbEtudiant++; // Incrémente automatiquement, lors de l'instentiation de la classe le nombre total d'étudiant
            idEtudiant = nbEtudiant; // Affectation de l'identifiant étudiant, de valeur le nombre d'étudiant au total
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

        public int getIdEtudiant(){ // Fonction qui retourne l'id d'un étudiant
            return idEtudiant;
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            Etudiant eleve1 = new Etudiant("John", "Doe", 18); // Instantiation de la classe étudiant avec l'objet eleve1

            TabEtudiant.ajouter(eleve1); // Ajoute l'élève au tableau

            eleve1.getTableauAll(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau      


            
            Etudiant eleve2 = new Etudiant("Pierre", "Durant", 20); // Instantiation de la classe étudiant avec l'objet eleve1 

            TabEtudiant.ajouter(eleve2); // Ajoute l'élève au tableau     

            eleve1.getTableauAll(eleve2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau

            eleve2.getTableauAll(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau 

        }
    }

}
