using System;

namespace RessourcesLib
{
    public class Services
    {
      private int NbRessourcesLibres;
      private int NbRessourcesOccupées;

      //Déclartaion du ou des constructeurs
      public Services(){} //Constructeur par défaut
      //Constructeurs par paramètres

      public Services(int nbRL) 
      {
        this.NbRessourcesLibres=nbRL;
        this.NbRessourcesOccupées=0;
      }
      //Ou bien  

      public Services(int nbRL, int nbRO)
      {        
        this.NbRessourcesLibres=nbRL;
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
    }
}
