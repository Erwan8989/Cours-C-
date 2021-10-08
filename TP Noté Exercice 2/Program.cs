using System;

namespace TP_Noté_Exercice_2
{

    class TabEtudiant
    {
        public static string [,] tableauEtudiant = tableauEtudiant = new string [30,3]; // Création du tableau en static afin d'avoir un tableau commun à tous les objets
        public TabEtudiant(){}


        public static void ajouter(Etudiant E){ // Fonction qui permet d'ajouter un étudiant au tableau avec son nom, prenom et note
            tableauEtudiant[E.getIdEtudiant(),0] = E.getPrenom();
            tableauEtudiant[E.getIdEtudiant(),1] = E.getNom();
            tableauEtudiant[E.getIdEtudiant(),2] = (E.getNote()).ToString();
            
            E.trierTableau(); // Appel de la fonction trierTaleau, afin de mettre à jour le classement après l'ajout d'un nouvel élève
            }
    

       public void getTableauAll(Etudiant E){ // Fonction qui permet de retourner toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
            int id = E.getIdEtudiant(); // Récupération de l'ID de l'étudiant pour l'identifier dans le tableau
            Console.WriteLine("L'étudiant avec l'ID " + id + " s'appelle " + tableauEtudiant[id, 0] + " " + tableauEtudiant[id, 1] + " et a comme note : " + tableauEtudiant[id, 2] + "/20");
           
       }

       public void trierTableau(){  // Fonction avec double boucle for qui va permettre de trier les élèves par ordre croissant selon leur note
            for (int i = 1; i < 5; i++)
            {
                    if (tableauEtudiant[i+1, 2] == null){ // Condition qui permet de ne pas sortir des limites du tableau
                        break;
                    }
                    else
                    {  
                    for (int j = 2; j < 5; j++){
                        if (tableauEtudiant[j, 2] == null) // Condition qui permet de ne pas sortir des limites du tableau
                        {
                            break;
                        }
                        else{ 

                            string prenom1 = tableauEtudiant[i, 0]; // Stockage des prenoms dans une variable
                            string prenom2 = tableauEtudiant[j, 0];

                            string nom1 = tableauEtudiant[i, 1]; // Stockage des noms dans une variable
                            string nom2 = tableauEtudiant[j, 1];

                            int valeur1 = int.Parse(tableauEtudiant[i, 2]); // Stockage des notes dans une variable. Conversion d'une chaine de caractère en entier, afin de pourvoir comparer les deux valeurs avec <. 
                            int valeur2 = int.Parse(tableauEtudiant[j, 2]);

                            if (valeur1 < valeur2){ /* Condition qui vérifie si la valeur la plus haute dans tableau est inférieur à celle en dessous d'elle. 
                                                        Si c'est le cas, ce n'est pas dans l'ordre croissant, donc il faut échanger leur positions */

                                int save = valeur1; // Sauvegarde des notes pour inversions
                                valeur1 = valeur2;
                                valeur2 = save;

                                string valeur1_string = valeur1.ToString(); // Conversion des valeur d'entier vers chaine de caractère afin de pourvoir les restocker dans le tableau. 
                                string valeur2_string = valeur2.ToString();
                                
                                tableauEtudiant[i, 2] = valeur1_string; // Affectation des nouvelles valeurs
                                tableauEtudiant[j, 2] = valeur2_string;

                                tableauEtudiant[i, 0] = prenom2; // Affectation des nouveaux prénoms
                                tableauEtudiant[j, 0] = prenom1;

                                tableauEtudiant[i, 1] = nom2; // Affectation des nouveaux noms
                                tableauEtudiant[j, 1] = nom1;
                            }
                        }
                    }

                }
                
            }
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
            Etudiant eleve1 = new Etudiant("John", "Doe", 10); // Instantiation de la classe étudiant avec l'objet eleve1

            TabEtudiant.ajouter(eleve1); // Ajoute l'élève au tableau

            // eleve1.getTableauAll(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau      


            
            Etudiant eleve2 = new Etudiant("Pierre", "Durant", 20); // Instantiation de la classe étudiant avec l'objet eleve1 

            TabEtudiant.ajouter(eleve2); // Ajoute l'élève au tableau     

            // eleve1.getTableauAll(eleve2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau

            // eleve2.getTableauAll(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau 


            Etudiant eleve3 = new Etudiant("Toto", "Dupont", 15); // Instantiation de la classe étudiant avec l'objet eleve1 

            TabEtudiant.ajouter(eleve3); // Ajoute l'élève au tableau    


            eleve1.getTableauAll(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
            eleve2.getTableauAll(eleve2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
            eleve3.getTableauAll(eleve3); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau 
            
            Console.WriteLine(TabEtudiant.tableauEtudiant[1, 0] + TabEtudiant.tableauEtudiant[1, 1] + TabEtudiant.tableauEtudiant[1, 2]);
            Console.WriteLine(TabEtudiant.tableauEtudiant[2, 0] + TabEtudiant.tableauEtudiant[2, 1] + TabEtudiant.tableauEtudiant[2, 2]);
            Console.WriteLine(TabEtudiant.tableauEtudiant[3, 0] + TabEtudiant.tableauEtudiant[3, 1] + TabEtudiant.tableauEtudiant[3, 2]);
        }
    }

}
