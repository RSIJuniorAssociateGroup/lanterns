using LanternsApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LanternsAppTest.Tests
{
    public class LanternsDedicationTest
    {
        private readonly LanternsDedication dedication = new LanternsDedication();
        
        [Theory]
        [InlineData(2, 6)]
        [InlineData(3, 8)]
        [InlineData(4, 9)]
        public void TestOneOfEachLength(int numberOfPlayers, int expectedListSize)
        {
            dedication.SetListsByNumberOfPlayers(numberOfPlayers);
            Assert.Equal(expectedListSize, dedication.FourOfAKind.Count);
            Assert.Equal(expectedListSize, dedication.ThreePair.Count);
            Assert.Equal(expectedListSize, dedication.OneOfEach.Count);
        }

        [Fact]
        public void TestInvalidNumberOfPLayers()
        {
            Assert.Throws<Exception>(() => dedication.SetListsByNumberOfPlayers(0));
        }
    }
}
