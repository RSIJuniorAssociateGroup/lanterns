using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanternsApp.Classes.LanternCard;

namespace UnitTestProject2.Tests
{
    [TestClass]
    public class LanternCardTest
    {
        [TestMethod]
        public void TestCreation()
        {
            LanternCard card = LanternCard.RED;
            Assert.AreEqual(card, LanternCard.RED);
        }
    }
}
