using LanternsApp.Models.Classes;
using System;
using Xunit;


namespace LanternsAppTest
{
    public class LanternCardTest
    {
        readonly LanternCard card = LanternCard.BLUE;
            
        [Fact]
        public void TestLanternCardColorPass()
        {
            Assert.NotEqual(LanternCard.RED, card);
        }

        [Fact]
        public void TestLanternColorFail()
        {
            Assert.Equal(LanternCard.RED, card);
        }

        [Fact]
        public void TestSameLanternColor()
        {
            Assert.Equal(LanternCard.BLUE, card);
        }
    }
}
