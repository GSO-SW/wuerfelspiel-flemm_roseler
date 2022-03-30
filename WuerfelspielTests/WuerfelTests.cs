using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_KannErstelltWerden()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act


            //Assert
            Assert.IsNotNull(w);
        }
    }
}
