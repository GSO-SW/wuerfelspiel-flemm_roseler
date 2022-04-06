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
            int AnzahlSeiten = 6;
            int LetztesErgebnis = -1;
            bool Gesichert = false;

            //Act
            Wuerfel w = new Wuerfel(AnzahlSeiten);

            //Assert
            Assert.AreEqual(AnzahlSeiten, w.AnzahlSeiten);
            Assert.AreEqual(LetztesErgebnis, w.LetztesErgebnis);
            Assert.AreEqual(Gesichert, w.Gesichert);
        }

        [TestMethod]
        public void SicherungUmschalten_SicherungKannUmgeschaltetWerden()
        {
            //Arrange
            bool GesicherterWuerfel = true;
            Wuerfel w = new Wuerfel(6);

            //Act
            w.SicherungUmschalten();

            //Arrange
            Assert.AreEqual(GesicherterWuerfel, w.Gesichert);
        }

        [TestMethod]
        public void Wuerfeln_WuerfelKannGewuerfeltWerden()
        {
            //Arrange
            Wuerfel w = new Wuerfel(6);

            //Act
            w.Wuerfeln();

            //Assert
            Assert.IsTrue(w.LetztesErgebnis > 0 && w.LetztesErgebnis < (w.AnzahlSeiten + 1));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Wuerfeln_WuerfelKannNichtGewuerfeltWerdenWennGesichert()
        {
            //Arrange
            Wuerfel w = new Wuerfel(6);

            //Act
            w.SicherungUmschalten();
            w.Wuerfeln();
        }
    }
}
