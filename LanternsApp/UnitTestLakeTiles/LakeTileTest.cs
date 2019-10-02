using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LanternsApp;

namespace UnitTestLakeTiles
{
    [TestClass]
    public class LakeTileTest
    {
        [TestMethod]
        public void ValidIdCreatesLakeTile()
        {
            var tile = new LakeTile();

            var response = tile.CanCreateTile(35);

            Assert.AreEqual(response, true);
        }

        [TestMethod]
        public void InvalidIdDoesNotCreateLakeTile()
        {
            var tile = new LakeTile();

            var response = tile.CanCreateTile(37);

            Assert.AreEqual(response, false);
        }
 
        [TestMethod]
        public void TestCreateValidLakeTile()
        {



            //Create test objects
            var TilePassingActual = new LanternsApp.LakeTile
            {
                TileId = 0,
                TopColorQuadrant = "Red",
                RightColorQuadrant = "White",
                BottomColorQuadrant = "Blue",
                LeftColorQuadrant = "Purple",
                OrientationQuadrant = 0,
                xCoordinate = 0,
                yCoordinate = 0
            };
            var TilePassingExpected = new LanternsApp.LakeTile
            {
                TileId = 0,
                TopColorQuadrant = "Red",
                RightColorQuadrant = "White",
                BottomColorQuadrant = "Blue",
                LeftColorQuadrant = "Purple",
                OrientationQuadrant = 0,
                xCoordinate = 0,
                yCoordinate = 0
            };

            ////Verify the method being tested behaves as expected
            Assert.AreEqual(TilePassingActual.TileId, TilePassingExpected.TileId);
            
            Assert.AreEqual(TilePassingActual.TopColorQuadrant, TilePassingExpected.TopColorQuadrant);
            Assert.AreEqual(TilePassingActual.RightColorQuadrant, TilePassingExpected.RightColorQuadrant);
            Assert.AreEqual(TilePassingActual.BottomColorQuadrant, TilePassingExpected.BottomColorQuadrant);
            Assert.AreEqual(TilePassingActual.LeftColorQuadrant, TilePassingExpected.LeftColorQuadrant);

            Assert.AreEqual(TilePassingActual.OrientationQuadrant, TilePassingExpected.OrientationQuadrant);
            Assert.AreEqual(TilePassingActual.xCoordinate, TilePassingExpected.xCoordinate);
            Assert.AreEqual(TilePassingActual.yCoordinate, TilePassingExpected.yCoordinate);

            //// Arrange data to be passed to methods being tested

            //// Invoking methods being tested
           
            ////Verify the method being tested behave as expected
        }
    }
}
