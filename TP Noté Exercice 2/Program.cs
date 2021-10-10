using System;

namespace TP_Noté_Exercice_2
{

    class TabEtudiant
    {
        public static string [,] tableauEtudiant = tableauEtudiant = new string [32,3]; // Création du tableau en static afin d'avoir un tableau commun à tous les objets
        public TabEtudiant(){}


        public static void ajouter(Etudiant E){ // Fonction qui permet d'ajouter un étudiant au tableau avec son nom, prenom et note
            tableauEtudiant[Etudiant.getNbEtudiant(),0] = E.getPrenom();
            tableauEtudiant[Etudiant.getNbEtudiant(),1] = E.getNom();
            tableauEtudiant[Etudiant.getNbEtudiant(),2] = (E.getNote()).ToString();
            
            E.trierTableau(); // Appel de la fonction trierTaleau, afin de mettre à jour le classement après l'ajout d'un nouvel élève
            }
    

       public void getTableauEtudiant(Etudiant E){ /* Fonction qui permet de retourner toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau 
                                                Correspond à la fonction "valeur" dans l'énoncé */
                                                
            int id = E.getIdEtudiant(); // Récupération de l'ID de l'étudiant pour l'identifier dans le tableau
            Console.WriteLine("L'étudiant avec l'ID " + id + " s'appelle " + tableauEtudiant[id, 0] + " " + tableauEtudiant[id, 1] + " et a comme note : " + tableauEtudiant[id, 2] + "/20");
           
       }

       public void trierTableau(){  // Fonction avec double boucle for qui va permettre de trier les élèves par ordre croissant selon leur note
            for (int i = 1; i <= Etudiant.getNbEtudiant(); i++)
            {
                    if (tableauEtudiant[i+1, 2] == null){ // Condition qui permet de ne pas sortir des limites du tableau
                        break;
                    }
                    else
                    {  
                    for (int j = i+1; j <= Etudiant.getNbEtudiant(); j++){
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
            TableauVide(); 
            
       }

       public void TableauVide(){//Fonction qui permet de placer les emplacement vides en fin de tableau
           for (int i = 1; i < 30; i++){ 
                if (tableauEtudiant[i, 0] == null && tableauEtudiant[i+1, 0] != null)
                {
                    string prenom1 = tableauEtudiant[i+1, 0]; // Stockage des prenoms dans une variable

                    string nom1 = tableauEtudiant[i+1, 1]; // Stockage des noms dans une variable

                    string valeur1 = tableauEtudiant[i+1, 2]; // Stockage des notes dans une variable. 


                    // Réaffectation des valeurs 
                    tableauEtudiant[i, 0] = prenom1; 

                    tableauEtudiant[i, 1] = nom1;

                    tableauEtudiant[i, 2] = valeur1;


                    tableauEtudiant[i+1, 0] = null;

                    tableauEtudiant[i+1, 1] = null;

                    tableauEtudiant[i+1, 2] = null;
                                   
                }
            }
       }

       public void supprimer(int id){ // Fonction avec une boucle for qui rend null les champs du tableau selon l'ID indiqué

           for (int i = 0; i < 3; i++) 
           {
               tableauEtudiant[id, i] = null;
           }

           TableauVide(); // Appel de la fonction pour mettre le vide laissé par la suppresion en fin de tableau

           Etudiant.nbEtudiant--; // Décrémenter de 1 le nombre d'étudiant

            
       }

        public void getTableauAll(){ // Fonction qui permet de retourner tous les champs du tableau 
            Console.WriteLine("***** Affichage du tableau au complet *****");
            for(int i = 1; i <= 30; i++)
            {
                if (tableauEtudiant[i, 0] == null) // Condition qui permet d'indiqué qu'une ligne du tableau n'appartient à aucun élève
                {
                    Console.WriteLine("La place n°" + i + " n'est pas attribué");
                }
                else{
                Console.WriteLine("L'étudiant avec la place n°" + i + " s'appelle " + tableauEtudiant[i, 0] + " " + tableauEtudiant[i, 1] + " et a comme note : " + tableauEtudiant[i, 2] + "/20");

                }
            }

             Console.WriteLine("***** Fin d'affichage du tableau au complet *****");
        }


        public void moyenneNote() { // Fonction qui affiche la moyenne des notes de la classe
            
            int somme = 0;
            double moyenne = 0;
 
            for (int i = 1; i <= Etudiant.nbEtudiant; i++) // Boucle for qui addition les notes total de tous les élèves
            {
                somme += int.Parse(tableauEtudiant[i, 2]);
            }

            moyenne = (double)somme / Etudiant.nbEtudiant; // somme divisée par le nombre total d'élève dans le la classe, résultat sous forme de double

            Console.WriteLine("La moyenne des notes des élèves de la classe est : " + String.Format("{0:0.00}", + moyenne)); // Retourne la moyenne avec deux chiffres après la virgule
        }

        public void noteHaute(){ // Fonction qui retourne la note la plus haute de la classe
            Console.WriteLine("La meilleure note de la classe est " + tableauEtudiant[1, 2] + "/20, détenu par " + tableauEtudiant[1, 0] + " " + tableauEtudiant[1, 1]);
        }

        public void noteBasse(){ // Fonction qui retourne la note la plus basse de la classe 
            Console.WriteLine("La moins bonne note de la classe est " + tableauEtudiant[Etudiant.nbEtudiant, 2] + "/20, détenu par " + tableauEtudiant[Etudiant.nbEtudiant, 0] + " " + tableauEtudiant[Etudiant.nbEtudiant, 1]);
        }

        public void resultats(){ // Fonction qui retourne la note la plus haute, la plus basse, et la moyenne de toute
            Console.WriteLine("***** Affichage des résulats de la classe *****");

            noteHaute();
            noteBasse();
            moyenneNote();

            Console.WriteLine("***** Fin d'affichage des résulats de la classe *****");
        }

        
    }

    class Etudiant : TabEtudiant // Classe fille Etudiant, qui hérite de TabEtudiant
    {
        private string nomEtudiant;
        private string prenomEtudiant;
        private int noteEtudiant;
        public static int nbEtudiant = 0; // Méthode qui compte le nombre d'étudiant au total
        private int idEtudiant;

        public Etudiant(string prenom, string nom, int note){ // Constructeur
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;

            if (note < 0 || note > 20) // Vérifie que la note entrée se situe bien entre 0 et 20, sinon renvoyer exeption
            {
                throw new IndexOutOfRangeException("Note entrée incorrecte, veuillez saisir une note entre 0 et 20");
            }
            else
            {
                this.noteEtudiant = note;
            }
            
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
            // ***** Scénario *****

            Etudiant eleve1 = new Etudiant("Serge", "Gainsbourg", 10); // Instantiation de la classe étudiant avec l'objet eleve1
            TabEtudiant.ajouter(eleve1); // Ajout de l'élève au tableau

            Etudiant eleve2 = new Etudiant("Louis", "de Funes", 20); // Instantiation de la classe étudiant avec l'objet eleve2 
            TabEtudiant.ajouter(eleve2); // Ajout de l'élève au tableau

            Etudiant eleve3 = new Etudiant("Walt", "Disney", 17); // Instantiation de la classe étudiant avec l'objet eleve3  
            TabEtudiant.ajouter(eleve3); // Ajout de l'élève au tableau

            Etudiant eleve4 = new Etudiant("George", "Washington", 5); // Instantiation de la classe étudiant avec l'objet eleve4
            TabEtudiant.ajouter(eleve4); // Ajout de l'élève au tableau

            Etudiant eleve5 = new Etudiant("Arthur", "Pandragon", 7); // Instantiation de la classe étudiant avec l'objet eleve5
            TabEtudiant.ajouter(eleve5); // Ajout de l'élève au tableau

            /* // Test d'ajout d'élève avec une note incorrecte
            Etudiant eleve6 = new Etudiant("Jeff", "Bezos", 22); // Instantiation de la classe étudiant avec l'objet eleve4
            TabEtudiant.ajouter(eleve6); // Ajoute l'élève au tableau
            */


            eleve1.getTableauAll(); // Affiche l'ensemble du tableau par ordre croissant, en fonction des notes

            eleve2.getTableauEtudiant(eleve2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau

            eleve3.resultats(); // On affiche les résultats de la classe

            eleve2.supprimer(2); // L'élève Walt Disney au rang 2 décide de quitter l'école. On le supprime donc du tableau

            eleve1.getTableauAll(); /* On affiche de nouveau tout le tableau, et constatons que l'élève Walt Disney n'est plus présent. 
                                    Entre temps, le trie des notes a été mis à jour, et la place vide laissée, a été placé en fin de tableau */

            Etudiant eleve7 = new Etudiant("Tom", "Ellis", 4); // Un nouvel étudiant s'ajoute à la classe
            TabEtudiant.ajouter(eleve7); // Ajout de l'élève au tableau

            eleve7.getTableauAll(); // On affiche de nouveau tout le tableau mis à jour
            eleve7.resultats(); // On affiche de nouveau les résultats de la classe mis à jour
        }
    }

}
