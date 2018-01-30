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
        public void PrisTest()
        {
            // Arrange
            Bil b1 = new Bil("1234", DateTime.Today);
            int expectedResult = 240;
            // Act
            var actualResult = b1.Pris();
            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            Bil b2 = new Bil("12345", DateTime.Today);
            string expectedResult = "Bil";
            // Act
            var actualResult = b2.Køretøj();
            //  Asset
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Metode jeg fandt ,som er den eneste der virke når der bliver kastet en exceptiom
        // Forstår den ikke helt?
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er for lang")]
        public void NummerpladeForLangException()
        {
           // Arrange
           Bil b3 = new Bil("123456789", DateTime.Today);

        }
    }
}