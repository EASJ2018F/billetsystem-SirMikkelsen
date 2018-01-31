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
            MC mc1 = new MC("1234", DateTime.Today);
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
            MC mc2 = new MC("12345", DateTime.Today);
            string expectedResult = "MC";

            // Act
            var actualResult = mc2.Køretøj();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}