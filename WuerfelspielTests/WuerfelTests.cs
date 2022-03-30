using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_KannWerteHaben()
        {
            //Arrange
            int anzahlSeiten = 6;
            Random rdm = new Random();

            //Act

            Wuerfel w = new Wuerfel(anzahlSeiten, rdm);

            //Assert

            Assert.AreEqual(anzahlSeiten, w.AnzahlSeiten);
        }
    }
}
