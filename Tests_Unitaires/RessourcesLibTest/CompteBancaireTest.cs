using System;
using Xunit;
using Compte_Bancaire;

namespace RessourcesLibTest
{
     public class Program
    {

        [Fact]
        public void test1()
        {

            Compte Perso1 = new Compte ("John Doe", 8367471, 500, 2); // Test de ka fonction depot et retrait
            Perso1.depot(200);
            Perso1.retrait(100);
            Perso1.retrait(1000);

            Xunit.Assert.Equal(600, Perso1.Solde);   //  L'opération réussi car le montant est bien égal à 600 après les 3 oparations.
        }

        [Fact]
        public void test2() // Test d'un booléen supérieur à 500 : est true

        {
            CompteLivret Perso2 = new CompteLivret ("Jeff Bezos", 8237465, 1000000000, 0.0000000000001);
            Perso2.depot(5000);

            Xunit.Assert.True (Perso2.getboolean); // L'opération réussi car le Booléen est bien supérieur à 500
        }

        [Fact]
         public void test3() // Test d'un booléen inférieur à 500 : est false

        {
            CompteCheque Perso3 = new CompteCheque ("Louis de Funes", 8237465, 35000, 0.5);
            Perso3.retrait(34700);

            Xunit.Assert.False (Perso3.getboolean);    // L'opération réussi car le Booléen est bien inférieur à 500      
        }
    }
}
