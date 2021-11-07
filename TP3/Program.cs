using System;

// Exercice Implémentation d'un Compte Bancaire
 
namespace Compte_Bancaire // espace de nom
{
        // Creation de la classe CompteBancaire
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
         
        protected void Crediter(double montant){
        Console.WriteLine("Votre solde est de : " + this.Solde);

        this.montant = 0;
        
        do
        {
            Console.Write("Combien voulez-vous deposer sur votre compte : ");
            montant = int.Parse(Console.ReadLine());

            if (montant <= 0)
            {
                Console.WriteLine("Crédit impossible");
            }
        } while (montant <= 0);

        this.Solde += montant;
        Console.WriteLine("Votre solde est maintenant de : " + this.Solde); }

        public void depot(double montant) {
            Crediter(montant);
        }

        public void repos(double prixRetrait) {
            Debiter(prixRetrait);
        }

        protected void Debiter(double prixRetrait){
            Console.WriteLine("Votre solde est de : " + this.Solde);
            this.prixRetrait = 0;
            
            do
            {
                Console.Write("qu'elle montant voulez vous retirer : ");
                prixRetrait = int.Parse(Console.ReadLine());

                if (this.Solde < prixRetrait)
                {
                    Console.WriteLine("Solde insuffisant !");
                    break;
                }

            } while (prixRetrait <= 0);
            this.Solde -= prixRetrait;
            Console.WriteLine("Votre solde est maintenant de : " + this.Solde);
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

        } 
// fin classe mère
// Classe CompteChèque dérivant de CompteBancaire
    public class CompteCheque : Compte {

        public CompteCheque () {}
            public CompteCheque (string titulaire,int numeroCompte,double Solde, double interet):base(titulaire,numeroCompte,Solde,interet) {}

    }

// Classe CompteLivret dérivant de CompteBancaire
    public class CompteLivret : Compte {

        public CompteLivret () {}
            public CompteLivret (string titulaire,int numeroCompte,double Solde, double interet):base(titulaire,numeroCompte,Solde,interet) {}

    }

    public class Program
    {
        static void Main(string[] args)
        {
 
            // Scenario 1 :
            Console.WriteLine("Test Scenario Compte Bancaire :\n");    

            Compte CB1 = new Compte("OULMI Céline",2339483,500,0.05);
            CB1.Affichage();
            CB1.depot(10);
            CB1.Affichage();
            CB1.repos(10);
            CB1.Affichage();
            CB1.depot(200);
            CB1.Affichage();
            CB1.repos(1000);
            CB1.Affichage();
            CB1.Taxe();
            CB1.Affichage();
            CB1.TauxInteret();
            CB1.Affichage();
         

            // Scenario 2 :
            Console.WriteLine("Test Scenario Compte Cheque :\n");

            CompteCheque CC1 = new CompteCheque("Nathalie EPSI",6747483,1000,0.06);
            CC1.Affichage();
            CC1.depot(4000);
            CC1.Affichage();
            CC1.depot(350);
            CC1.Affichage();
            CC1.Taxe();
            CC1.Affichage();
            CC1.TauxInteret();
            CC1.Affichage();
            CC1.depot(600);
            CC1.TauxInteret();
            CC1.Affichage();

            
            // Scenario 3 :
            Console.WriteLine("Test Scenario Compte Livret :\n");

            CompteLivret CL1 = new CompteLivret("John Danone",547362,500,0.1);
            CL1.Affichage();
            CL1.depot(4000);
            CL1.Affichage();
            CL1.depot(30000);
            CL1.Affichage();
            CL1.Taxe();
            CL1.TauxInteret();
            CL1.Affichage();
            CL1.depot(400);
            CL1.Taxe();
            CL1.Affichage();
        }
    }
         
}

  


