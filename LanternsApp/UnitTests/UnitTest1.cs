using System;
using LanternsApp;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidIdCreatesLakeTile()
        {
            var tile = new LakeTile("", "", "", "");

            var response = 

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
@@ -18,8 +42,8 @@ public void TestCreateValidLakeTile()
                    BottomColorQuadrant = "Blue",
                LeftColorQuadrant = "Purple",
                OrientationQuadrant = 0,
                XCoordinate = 0,
                YCoordinate = 0
                    xCoordinate = 0,
                yCoordinate = 0
                };
        var TilePassingExpected = new LanternsApp.LakeTile
            {
@@ -29,49 +53,27 @@ public void TestCreateValidLakeTile()
                    BottomColorQuadrant = "Blue",
                LeftColorQuadrant = "Purple",
                OrientationQuadrant = 0,
                XCoordinate = 0,
                YCoordinate = 0
                xCoordinate = 0,
                yCoordinate = 0
            };

    ////Verify the method being tested behave as expected
    Console.WriteLine(Assert.AreEqual(TilePassingActual.TileId, TilePassingExpected.TileId));

            ////Verify the method being tested behaves as expected
            Assert.AreEqual(TilePassingActual.TileId, TilePassingExpected.TileId);
            
            Assert.AreEqual(TilePassingActual.TopColorQuadrant, TilePassingExpected.TopColorQuadrant);
            Assert.AreEqual(TilePassingActual.RightColorQuadrant, TilePassingExpected.RightColorQuadrant);
            Assert.AreEqual(TilePassingActual.BottomColorQuadrant, TilePassingExpected.BottomColorQuadrant);
            Assert.AreEqual(TilePassingActual.LeftColorQuadrant, TilePassingExpected.LeftColorQuadrant);

            Assert.AreEqual(TilePassingActual.OrientationQuadrant, TilePassingExpected.OrientationQuadrant);
            Assert.AreEqual(TilePassingActual.XCoordinate, TilePassingExpected.XCoordinate);
            Assert.AreEqual(TilePassingActual.YCoordinate, TilePassingExpected.YCoordinate);
            Assert.AreEqual(TilePassingActual.xCoordinate, TilePassingExpected.xCoordinate);
            Assert.AreEqual(TilePassingActual.yCoordinate, TilePassingExpected.yCoordinate);

            //// Arrange data to be passed to methods being tested

            //int tileIdNumber = 0;

            //string redColor = "Red";
            //string whiteColor = "White";
            //string blueColor = "Blue";
            //string purpleColor = "Purple";

            //int tileOrientation = 0;
            //int tileXCoord = 0;
            //int tileYCoord = 0;
            //// Invoking methods being tested
            //var PassingLakeTile = new LanternsApp.LakeTile();

            //PassingLakeTile.TileId = tileIdNumber;

            //PassingLakeTile.TopColorQuadrant = redColor;
            //PassingLakeTile.RightColorQuadrant = whiteColor;
            //PassingLakeTile.BottomColorQuadrant = blueColor;
            //PassingLakeTile.LeftColorQuadrant = purpleColor;

            //PassingLakeTile.OrientationQuadrant = tileOrientation;
            //PassingLakeTile.XCoordinate = tileXCoord;
            //PassingLakeTile.YCoordinate = tileYCoord;

            ////Verify the method being tested behave as expected
            //Assert.AreEqual(expectedTopColor, PassingLakeTile.TopColorQuadrant);
        }
}
}

    }
}
