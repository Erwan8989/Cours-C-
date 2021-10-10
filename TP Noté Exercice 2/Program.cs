using System;

namespace TP_Noté_Exercice_2
{

    class TabEtudiant
    {
        public static string [,] tableauEtudiant = tableauEtudiant = new string [31,3]; // Création du tableau en static afin d'avoir un tableau commun à tous les objets
        public TabEtudiant(){}


        public static void ajouter(Etudiant E){ // Fonction qui permet d'ajouter un étudiant au tableau avec son nom, prenom et note
            tableauEtudiant[E.getIdEtudiant(),0] = E.getPrenom();
            tableauEtudiant[E.getIdEtudiant(),1] = E.getNom();
            tableauEtudiant[E.getIdEtudiant(),2] = (E.getNote()).ToString();
            
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

       public void supprimer(int id){

           for (int i = 0; i < 3; i++) // Boucle for qui rend null les champs du tableau selon l'ID indiqué
           {
               tableauEtudiant[id, i] = null;
           }

           TableauVide(); // Appel de la fonction pour mettre le vide laissé par la suppresion en fin de tableau

           Etudiant.nbEtudiant--; // Décrémenter de 1 le nombre d'étudiant

            
       }

        public void getTableauAll(){ // Fonction qui permet de retourner tous les champs du tableau 
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
            noteHaute();
            noteBasse();
            moyenneNote();
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

            // eleve1.getTableauEtudiant(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau      
            // Console.WriteLine("La note est " +eleve1.getNote());

            
            Etudiant eleve2 = new Etudiant("Pierre", "Durant", 20); // Instantiation de la classe étudiant avec l'objet eleve2 

            TabEtudiant.ajouter(eleve2); // Ajoute l'élève au tableau     

            // eleve1.getTableauEtudiant(eleve2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau

            // eleve2.getTableauEtudiant(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau 


            Etudiant eleve3 = new Etudiant("Toto", "Dupont", 15); // Instantiation de la classe étudiant avec l'objet eleve3    

            TabEtudiant.ajouter(eleve3); // Ajoute l'élève au tableau    
            
            // eleve1.getTableauEtudiant(eleve1); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
            // eleve2.getTableauEtudiant(eleve2); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau
            // eleve3.getTableauEtudiant(eleve3); // Affiche toutes les informations d'un étudiant (prenom, nom et note) depuis le tableau

            // Console.WriteLine("La note est " +eleve1.getNote());
            // Console.WriteLine("L'ID de l'étudiant est " +eleve1.getIdEtudiant());
            
            
   
            Etudiant eleve4 = new Etudiant("James", "Durant", 8); // Instantiation de la classe étudiant avec l'objet eleve4
            TabEtudiant.ajouter(eleve4); // Ajoute l'élève au tableau  
          

            // Console.WriteLine(TabEtudiant.tableauEtudiant[1, 0] + TabEtudiant.tableauEtudiant[1, 1] + TabEtudiant.tableauEtudiant[1, 2]);
            // Console.WriteLine(TabEtudiant.tableauEtudiant[2, 0] + TabEtudiant.tableauEtudiant[2, 1] + TabEtudiant.tableauEtudiant[2, 2]);
            // Console.WriteLine(TabEtudiant.tableauEtudiant[3, 0] + TabEtudiant.tableauEtudiant[3, 1] + TabEtudiant.tableauEtudiant[3, 2]);
            // Console.WriteLine(TabEtudiant.tableauEtudiant[4, 0] + TabEtudiant.tableauEtudiant[4, 1] + TabEtudiant.tableauEtudiant[4, 2]);

            // Console.WriteLine("L'ID de l'étudiant est " +eleve4.getIdEtudiant());

            Etudiant eleve5 = new Etudiant("Merlin", "Tupi", 16); // Instantiation de la classe étudiant avec l'objet eleve5
            TabEtudiant.ajouter(eleve5); // Ajoute l'élève au tableau  

            eleve1.supprimer(2);
            eleve1.supprimer(3);
            eleve1.getTableauAll();
            
            eleve1.resultats();
            // eleve1.getTableauAll();

        }
    }

}
