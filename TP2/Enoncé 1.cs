// using System;

// namespace TP2
// {
//     class program 
//     {

//         static void Main(string[] args)
//         {
//             console.WriteLine ("Helloworld");

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

//         public service (){
//         }

//         // Constructeurs pas paramètres
//         public service (int nbrl) {
//             this.nbRessourcesLibres=nbrl;
//             this.nbRessourcesOccupées=0;
//         }

//         public service (int nbrl, int nbro) {
//             this.nbRessourcesLibres=nmrl;
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
//                 nbRessourcesLibres =- nb;
//                 nbRessourcesOccupées =+ nb;
//             }

//             else {
//                 console.WriteLine("Plus de ressources disponibles...");
//             }
        
//         }

//         // Doit passer par une méthode public pour faire appel à une méthode privée

//         public void RendreRessources (int nb) {
//             if (get_nbRessourcesOccupées () >= nb) {
//                 nbRessourcesLibres =+ nb;
//                 nbRessourcesOccupées =- nb;
//             }
//             else {
//                 console.WriteLine("Plus de ressources occupées...");
//             }

           /* // public int RessourcesLibres () {
            //     return nbRessourcesLibres;
            // } */

//             public void afficher_Ressources () {
//                 console.WriteLine("Nombre de ressources libres " + get_nbRessourcesLibres());
//                 console.WriteLine("njombre de ressources occupées " + get_nbRessourcesOccupées());
//             }

//         }

//         }
//     }

    
