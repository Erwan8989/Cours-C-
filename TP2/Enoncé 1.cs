using System;

namespace C___TP
{
class Program
   {
      static void Main(string[] args){
         
        Console.WriteLine("Hello World");


         Service Salle1=new Service(15);
         Salle1.Afficher_Ressources();
         Salle1.PriseRessources(2);
         Salle1.Afficher_Ressources();
         Salle1.PriseRessources(13);
         Salle1.Afficher_Ressources();  
         Salle1.PriseRessources(1);
         Salle1.RendreRessources(15);
         Salle1.Afficher_Ressources();

         Service Salle_Apple=new Service(10);
         Salle_Apple.Afficher_Ressources();
         

         Console.WriteLine("NBR Ressources libres:Salle1.get_NbRessourcesLibres()");
      } //Fin Main

   } // Fin Classe principal



   //Déclartaion de la classe Service pour la gestion des ressources
   class Service {
     
      private int NbRessourcesLibres;
      private int NbRessourcesOccupées;

      //Déclartaion du ou des constructeurs
      public Service(){} //Constructeur par défaut
//Constructeurs par paramètres

      public Service(int nbRL)
      {this.NbRessourcesLibres=nbRL;
      this.NbRessourcesOccupées=0;
      }
      //Ou bien  

      public Service(int nbRL, int nbRO)
      {        this.NbRessourcesLibres=nbRL;
         this.NbRessourcesOccupées=nbRO;
      }
      //Déclaration des méthodes Get et Set
      //get pour la lecture et accès aux attributs en private
public int get_NbRessourcesLibres(){ return NbRessourcesLibres;}
public int get_NbRessourceslibres(){ return NbRessourcesLibres;}
public int get_NbRessourcesOccupées(){return NbRessourcesOccupées;}
// set pour modifier en écriture les attributs en private
      public void set_NbRessourcesLibres(int nb) {
         this.NbRessourcesLibres=nb;
 }
      public void set_NbRessourcesOccupées(int nb) {
         this.NbRessourcesOccupées=nb;
      }
//Declaration des autres méthodes
// Méthodede prise de ressources
public void PriseRessources(int nb)
{
   if (get_NbRessourcesLibres()>=nb){
      NbRessourcesLibres=-nb;
      // ou bien NbRessourcesLibres=NbRessourcesLibre
      NbRessourcesOccupées=+nb;
   }//fermeture du if
else {
Console.WriteLine("Plus de ressources disponibles ...  ");
}
}
public void RendreRessources(int nb){
   if (get_NbRessourcesOccupées() >= nb){
      NbRessourcesLibres=+nb;
      NbRessourcesOccupées=-nb;
       }
   else
   Console.WriteLine("Plus de Ressources Occupées");}
public int RessourcesLibres()
{return NbRessourcesLibres;}
public void Afficher_Ressources(){
   Console.WriteLine("Nombre de ressources libres " + NbRessourcesLibres);
   Console.WriteLine("Nombre de ressources occupées " + NbRessourcesOccupées );
}
}//fin  class
   }