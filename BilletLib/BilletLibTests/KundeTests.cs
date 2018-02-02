using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class KundeTests
    {
       
        [TestMethod()]
        public void TotalPrisTest()
        { 
            //Arrange
            List<Kørertøj> kørertøj = new List<Kørertøj>();

            kørertøj.Add(new MC("1234", new DateTime(2018, 1, 25), false, false));
            kørertøj.Add(new Bil("1235" , new DateTime(2018, 1, 25), false, false));
            kørertøj.Add(new Bil("1235" , new DateTime(2018, 1, 25), true, false));
          
            Kunde kunde = new Kunde(kørertøj);

            // Act
            int result = kunde.TotalPris();

            // Assert
            Assert.AreEqual(593, result);
        }
    }
}