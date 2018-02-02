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
    public class MCTests
    {
        [TestMethod()]
        public void PrisForMCTest()
        {
            // Arrange 
            MC mc1 = new MC("1234", new DateTime(2018, 2, 1), false, false);
            int expectedResult = 125;
            
            // Act
            var actualResult = mc1.Pris();
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod()]
        public void KøretøjForMCTest()
        {
            // Arrange
            MC mc2 = new MC("12345", new DateTime(2018, 2, 1), false, false);
            string expectedResult = "MC";

            // Act
            var actualResult = mc2.Køretøj();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void BrobizzRabatForMcTest()
        {
            // Arrange
            MC mc3 = new MC("1234", new DateTime(2018, 2, 1), true, false);
            int expectedResult = 115;
            // Act
            var actualResult = mc3.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }



        //Metode jeg fandt ,som er den eneste der virker når der bliver kastet en exception
        // Forstår den ikke helt?
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er for lang")]
        public void NummerpladeForLangForMCException()
        {
            // Arrange
            MC m4 = new MC("123456789", new DateTime(2018, 2, 1), false, false);

        }

        [TestMethod]
        public void GetNummerpladeForMCTest()
        {
            // Arrange 
            MC mc5 = new MC("1234", new DateTime(2018, 2, 1), false, false);
            string expectedResult = "1234";

            // Act
            var actualResult = mc5.Nummerplade;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void GetBrobizzForMCTest()
        {
            // Arrange 
            MC mc6 = new MC("1234", new DateTime(2018, 2, 1), false, false);
            bool expectedResult = false;

            // Act
            var actualResult = mc6.Brobizz;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void PrisForØresundMCTest()
        {
            // Arrange 
            MC mc7 = new MC("1234", new DateTime(2018, 2, 1), false, true);
            int expectedResult = 210;

            // Act
            var actualResult = mc7.Pris();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]

        public void ØresundBrobizzRabatForMcTest()
        {
            // Arrange
            MC mc8 = new MC("1234", new DateTime(2018, 2, 1), true, true);
            int expectedResult = 73;
            // Act
            var actualResult = mc8.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void GetØresundForMCTest()
        {
            // Arrange 
            MC mc9 = new MC("1234", new DateTime(2018, 2, 1), false, false);
            bool expectedResult = false;

            // Act
            var actualResult = mc9.Øresund;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void KøretøjForØresundMCTest()
        {
            // Arrange
            MC mc10 = new MC("12345", new DateTime(2018, 2, 1), false, true);
            string expectedResult = "Øresund MC";

            // Act
            var actualResult = mc10.Køretøj();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


       

    }
}
