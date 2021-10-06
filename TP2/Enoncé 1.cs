// using System;

// namespace TP2
// {
//     class program 
//     {

//         static void Main(string[] args)
//         {
//             Console.WriteLine ("Helloworld");
//             Services Salle1 = new Services(15);
//             // Salle1 est un objet instance de la classe Service
//             Salle1.afficherRessources();
//             Salle1.PriseRessources(2);     // prise de 2 pc
//             Salle1.afficherRessources();
//             Salle1.PriseRessources(12);
//             Salle1.afficherRessources();
//             Salle1.PriseRessources(1);  
//             Salle1.RendreRessources(15);
//             Salle1.afficher_Ressources();

//             Services Salle_apple = new Services (10);
//             Salle_apple.afficherRessources();
//             Salle_apple.PriseRessources(15);
//         // Déclaration et création des objets de classe Ressources
                  
//         } 
//     }

//     // Déclaration de la classe Service 
//     class Services {
        
//         // Déclaration des attributs ou bien des caractéristiques des objets
//         // En privés, sécurisés avec accès via get et set
//         private int nbRessourcesLibres;
//         private int nbRessourcesOccupées;

//         // Déclaration du ou des constructeurs

//         public void Service (){
//         }

//         // Constructeurs pas paramètres
//         // public void service (int nbrl) {
//         //     this.nbRessourcesLibres=nbrl;
//         //     this.nbRessourcesOccupées=0;
//         // }

//         public void Service (int nbrl, int nbro) {
//             this.nbRessourcesLibres=nbrl;
//             this.nbRessourcesOccupées=nbro;
//         }

//         // getters pour la lecture et accès aux attributs en private :fonctions.

//         public int get_nbRessourcesLibres() {
//             return nbRessourcesLibres;
//         }

//         public int get_nbRessourcesOccupées() {
//             return nbRessourcesOccupées;
//         }

//         // Setters pour modifier les attributs en private 

//         public void set_nbRessourcesLibres(int nb) { // nb > 0
//             this.nbRessourcesLibres=nb;
//         }

//         public void set_nbRessourcesOccupées(int nb) { // nb > 0
//             this.nbRessourcesOccupées=nb;
//         }


//         // Déclaration des méthodes diverses

//         public void PriseRessources (int nb) {
//             if (get_nbRessourcesLibres() >=nb) {
//                 nbRessourcesLibres -= nb;
//                 nbRessourcesOccupées += nb;
//             }

//             else {
//                 Console.WriteLine("Plus de ressources disponibles...");
//             }      
//         }

//         // Doit passer par une méthode public pour faire appel à une méthode privée

//         public void RendreRessources (int nb) {
//             if (get_nbRessourcesOccupées () >= nb) {
//                 nbRessourcesLibres += nb;
//                 nbRessourcesOccupées -= nb;
//             }
//             else {
//                 Console.WriteLine("Plus de ressources occupées...");
//             }

//             // public int RessourcesLibres () {
//             //     return nbRessourcesLibres;
//             // } 
//             }

//         public void afficherRessources () {
//             Console.WriteLine("Nombre de ressources libres " + get_nbRessourcesLibres());
//             Console.WriteLine("Nombre de ressources occupées " + get_nbRessourcesOccupées());
//         } 

//     }
// }
    

    
