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
        public void PrisTest()
        {
            // Arrange 
            MC mc1 = new MC();
            int expectedResult = 125;
            
            // Act
            var actualResult = mc1.Pris();
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            MC mc1 = new MC();
            string expectedResult = "MC";

            // Act
            var actualResult = mc1.Køretøj();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}