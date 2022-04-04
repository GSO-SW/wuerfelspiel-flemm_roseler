﻿using System;
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
    }
}
