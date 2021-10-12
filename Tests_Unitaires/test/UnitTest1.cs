using System;
using Xunit;
using Lib;
namespace test
{
    public class UnitTest1
    {
        [Fact]
        // public void Test1()
        // {
        // int SOM = Class1.Somme(2, 3); 
        // Xunit.Assert.Equal(5, SOM);
        // }
        // [Fact]
        // public void Test2()
        // {
        // int PROD = Class1.Produit(4,5);
        // Xunit.Assert.Equal(20, PROD);
        // }

        public void testMethod () {
            Calcules c = new Calcules();
            double m = c.CalculerMoyenne(11,11,12);
            Xunit.Assert.Equal(m, 11.2);
        }
    }
}
