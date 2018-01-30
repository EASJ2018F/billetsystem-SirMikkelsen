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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            // Arrange
            Bil b1 = new Bil();
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
            Bil b2 = new Bil();
            string expectedResult = "Bil";
            // Act
            var actualResult = b2.Køretøj();
            //  Asset
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}