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

            // Act

            var minBil1 = b1.Pris();

            // Asset
            Assert.AreEqual(240, minBil1 );
        }

        [TestMethod()]
        public void køretøjTest()
        {
            // Arrange
            Bil b2 = new Bil();

            // Act

            var minBil2 = b2.køretøj();

            //  Asset
            Assert.AreEqual("Bil", minBil2);
        }
    }
}