using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisForBilTest()
        {
            // Arrange
            Bil b1 = new Bil("1234", DateTime.Today, false, false);
            int expectedResult = 240;
            // Act
            var actualResult = b1.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BrobizzRabatForBilTest()
        {
            // Arrange
            Bil b2 = new Bil("1234", DateTime.Today, true, false);
            int expectedResult = 230;
            // Act
            var actualResult = b2.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void WeekendRabatForBilTest()
        {
           // Arange
           Bil b3 = new Bil("1234",DateTime.Today, true, false);
           int expectedResult = 190;
           
           // Act
           var actualResult = b3.Pris();
           
           // Asset
           Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void KøretøjForBilTest()
        {
            // Arrange
            Bil b4 = new Bil("12345", DateTime.Today, false, false);
            string expectedResult = "Bil";
            
            // Act
            var actualResult = b4.Køretøj();
            
            //  Asset
            Assert.AreEqual(expectedResult, actualResult);
        }


        //Metode jeg fandt ,som er den eneste der virker når der bliver kastet en exception
        // Forstår den ikke helt?
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er for lang")]
        public void NummerpladeForLangForBilException()
        {
            // Arrange
            Bil b5 = new Bil("123456789", DateTime.Today, false, false);

        }


        [TestMethod]
        public void GetNummerpladeForBilTest()
        {
            // Arrange 
            Bil b6 = new Bil("1234", DateTime.Today, false, false);
            string expectedResult = "1234";

            // Act
            var actualResult = b6.Nummerplade;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        public void GetBrobizzForBilTest()
        {
            // Arrange 
            Bil b7  = new Bil("1234", DateTime.Today, false, false);
            bool expectedResult = false;

            // Act
            var actualResult = b7.Brobizz;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);


        }



        [TestMethod()]
        public void PrisForØresundBilTest()
        {
            // Arrange
            Bil b8 = new Bil("1234", DateTime.Today, false, true);
            int expectedResult = 410;
            // Act
            var actualResult = b8.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ØresundBrobizzRabatForBilTest()
        {
            // Arrange
            Bil b9 = new Bil("1234", DateTime.Today, true, true);
            int expectedResult = 161;
            // Act
            var actualResult = b9.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void GetØresundForBilTest()
        {
            // Arrange 
            Bil b10 = new Bil("1234", DateTime.Today, false, false);
            bool expectedResult = false;

            // Act
            var actualResult = b10.Øresund;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void KøretøjForØresundBilTest()
        {
            // Arrange
            Bil b11 = new Bil("12345", DateTime.Today, false, true);
            string expectedResult = "Øresund Bil";

            // Act
            var actualResult = b11.Køretøj();

            //  Asset
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}