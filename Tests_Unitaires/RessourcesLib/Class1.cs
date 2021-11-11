using System;

namespace Compte_Bancaire
{
    public class Compte {

            // Initialisation des attributs en protected car cas d'héritage
            protected double solde;
            protected double interet;
            protected int numeroCompte ;
            protected string titulaire;

            // on initialise deux dates pour pouvoir les utiliser dans taxe et interet en meme temps
            protected int date;
            protected int date2;   
            protected double montant;
            protected double prixRetrait;
            
// Conctructeurs
        public Compte (){ }
        public Compte(string titulaire,int numeroCompte, double Solde,double interet)
        {
            this.titulaire = titulaire;
            this.numeroCompte = numeroCompte;
            this.solde = Solde;  
            this.interet = interet; 
            this.date = DateTime.Now.Month;
            this.date2 = DateTime.Now.Month;       
        }
        // Les getters et les setters d'une autre forme
            public string Titulaire {
                get => titulaire;
                set => titulaire = value;
            }

            public double Solde {
                get => solde;
                set => solde = value;

            }

            public int NumeroCompte {
                get => numeroCompte;
                set => numeroCompte = value;

            }

            public double Interet {
                get => interet;
                set => interet = value;

            }

// Ajout d'une saisie utilisateur 
// Utilisation du mot clé new pour le masquage du membre hérité 
        public void Affichage(){
            Console.WriteLine("Titulaire : {0};\nN° de compte: {1};\nMontant :   {2};\n", this.Titulaire , this.NumeroCompte , this.Solde);
        }
         
        protected void Crediter(double montant) {
            Console.WriteLine("Votre solde est de : " + this.Solde);

            this.montant = 0;
            
            while (montant <= 0)
            {
                Console.Write("Combien voulez-vous deposer sur votre compte : ");
                montant = int.Parse(Console.ReadLine());

                if (montant >= 0) {

                    this.Solde += montant;
                    Console.WriteLine("Votre solde est maintenant de : " + this.Solde);  
                }

                else 
                {
                    Console.WriteLine("Crédit impossible");
                    break;
                }
            }                 
        }

        protected void Debiter(double prixRetrait){
            Console.WriteLine("Votre solde est de : " + this.Solde);
            this.prixRetrait = 0;
            
            while (prixRetrait <= 0)

            {
                Console.Write("qu'elle montant voulez vous retirer : ");
                prixRetrait = int.Parse(Console.ReadLine());

                if ((this.Solde - prixRetrait) >= 0)
                {
                    this.Solde -= prixRetrait;
                    Console.WriteLine("Votre solde est maintenant de : " + this.Solde);         
                } 

                else {
                    Console.WriteLine("Solde insuffisant !");
                    break;
                }
            }          
        }

        public void Taxe()
        {          
        // Ici on rajoute 1 la date et il faudra attendre 1 mois avant de pouvoir refaire cette methode sur le compte 
            if (this.date == DateTime.Now.Month) {
            this.Solde -= 5;  
            this.date ++;
            if (this.date == 12){
                this.date = 1;  
            }}       
        }

        public void TauxInteret()
        {
            // réutilisation de la méthode utilisée pour taxe mais avec date2 pour éviter un bug. 
            if (this.date2 == DateTime.Now.Month) {
            this.Solde = this.Solde * this.interet + this.Solde;
            this.date2 ++;
            if (this.date2 == 12){
                this.date2 = 1;
                }
            }       
        }
         public void depot(double montant) {
            Crediter(montant);
        }

        public void retrait(double prixRetrait) {
            Debiter(prixRetrait);
        }
} 

    public class CompteCheque : Compte {

        public CompteCheque () {}
            public CompteCheque (string titulaire,int numeroCompte,double Solde, double interet):base(titulaire,numeroCompte,Solde,interet) {}
            new public void TauxInteret()
        {
            if (this.Solde > 500){
                if (this.date2 == DateTime.Now.Month) {
                    this.Solde = this.Solde * this.interet + this.Solde;
                    this.date2 ++;
                     if (this.date2 == 12){
                        this.date2 = 1;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Pas de fond suffisant pour profiter des intérets!\n");
                }
        }
    }

// Classe CompteLivret dérivant de CompteBancaire
    public class CompteLivret : Compte {

        public CompteLivret () {}
            public CompteLivret (string titulaire,int numeroCompte,double Solde, double interet):base(titulaire,numeroCompte,Solde,interet) {}

            new public void Taxe()
        {
            if (this.Solde < 200){
                if (this.date == DateTime.Now.Month) {
                    this.Solde -= 5;  
                    this.date ++;
                    if (this.date == 12){
                       this.date = 1;
                      }
                }  
            }  

            else
            {
                Console.WriteLine("Ce compte ne peut etre taxé !\n");
            }
        }
    }

}
