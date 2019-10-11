using LanternsApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        [Theory]
        [InlineData(2, 10)]
        [InlineData(3, 10)]
        [InlineData(4, 10)]
        public void TestOneOfEachIndexInitialValues(int numberOfPlayers, int expectedValue)
        {
            dedication.SetListsByNumberOfPlayers(numberOfPlayers);
            Assert.Equal(expectedValue, dedication.OneOfEach[dedication.OneOfEachIndex]);
        }

        [Theory]
        [InlineData(2, 9)]
        [InlineData(3, 9)]
        [InlineData(4, 9)]
        public void TestThreePairIndexInitialValues(int numberOfPlayers, int expectedValue)
        {
            dedication.SetListsByNumberOfPlayers(numberOfPlayers);
            Assert.Equal(expectedValue, dedication.ThreePair[dedication.ThreePairIndex]);
        }

        [Theory]
        [InlineData(2, 8)]
        [InlineData(3, 8)]
        [InlineData(4, 8)]
        public void TestFourOfAKindIndexInitialValues(int numberOfPlayers, int expectedValue)
        {
            dedication.SetListsByNumberOfPlayers(numberOfPlayers);
            Assert.Equal(expectedValue, dedication.FourOfAKind[dedication.FourOfAKindIndex]);
        }

        [Theory]
        [InlineData(4, "OneOfEach", new int[] { 5, 6, 7, 7, 8, 8, 9, 9, 10 })]
        [InlineData(4, "ThreePair", new int[] { 5, 5, 6, 6, 7, 7, 8, 8, 9 })]
        [InlineData(4, "FourOfAKind", new int[] { 4, 5, 5, 5, 6, 6, 7, 7, 8 })]
        public void TestGiveDedicationToPlayer(int numberOfPlayers, string dedicationType, int[] expectedValues)
        {
            dedication.SetListsByNumberOfPlayers(numberOfPlayers);

            for (int i = expectedValues.Length - 1; i > -1; i--)
            {
                Assert.Equal(expectedValues[i], dedication.GiveDedicationToPlayer(dedicationType));
            }
        }

        [Theory]
        [InlineData(4, "OneOfEach", 4)]
        [InlineData(4, "ThreePair", 4)]
        [InlineData(4, "FourOfAKind", 4)]
        public void TestGenericDedication(int numberOfPlayers, string dedicationType, int expectedValue)
        {
            dedication.SetListsByNumberOfPlayers(numberOfPlayers);

            dedication.OneOfEachIndex = -1;
            dedication.ThreePairIndex = -1;
            dedication.FourOfAKindIndex = -1;

            Assert.Equal(expectedValue, dedication.GiveDedicationToPlayer(dedicationType));
        }

        [Fact]
        public void TestIncorrectDedicationType()
        {
            Assert.Throws<Exception>(() => dedication.GiveDedicationToPlayer("test"));
        }
    }
}
