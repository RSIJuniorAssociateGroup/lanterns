using LanternsApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LanternsAppTest.Tests
{
    public class LanternsBoardTest
    {
        private LanternsBoard lanternsBoard = new LanternsBoard(3, 3);

        private readonly LakeTile lakeTile1 = new LakeTile("red", "red", "red", "red");
        private readonly LakeTile lakeTile2 = new LakeTile("blue", "blue", "blue", "blue");
        private readonly LakeTile lakeTile3 = new LakeTile("green", "green", "green", "green");

        [Theory]
        [InlineData(10, 10)]
        [InlineData(-1, -1)]
        [InlineData(10, 2)]
        [InlineData(2, 10)]
        [InlineData(2, -1)]
        [InlineData(-1, 2)]
        public void TestInvalidPlaceBoardTile(int row, int column)
        {
            Assert.False(lanternsBoard.PlaceLakeTileOnBoard(lakeTile1, row, column));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, 1)]
        [InlineData(1, 2)]
        public void TestPlaceBoardTile(int row, int column)
        {
            lanternsBoard.PlaceInitialLakeTile(lakeTile2, 1, 1);
            lanternsBoard.PlaceLakeTileOnBoard(lakeTile2, row, column);
            var boardTile = lanternsBoard.Board.Find(tile => tile.Row == row && tile.Column == column);

            Assert.Equal(boardTile.TileId, lakeTile2.TileId);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2, 2)]
        [InlineData(1, 1)]
        [InlineData(0, 2)]
        public void TestBoardTileAlreadyFilled(int row, int column)
        {
            lanternsBoard.PlaceLakeTileOnBoard(lakeTile2, row, column);
            Assert.False(lanternsBoard.PlaceLakeTileOnBoard(lakeTile3, row, column));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 2)]
        [InlineData(2, 0)]
        [InlineData(2, 2)]
        public void TestPlacementWithoutAdjacentTiles(int row, int column)
        {
            lanternsBoard.PlaceInitialLakeTile(lakeTile2, 1, 1);
            Assert.False(lanternsBoard.PlaceLakeTileOnBoard(lakeTile1, row, column));
        }

        [Fact]
        public void TestInitialTilePlacement()
        {
            lanternsBoard.PlaceInitialLakeTile(lakeTile3, 0, 0);
            var boardTile = lanternsBoard.Board.Find(tile => tile.Row == 0 && tile.Column == 0);
            Assert.Equal(lakeTile3.TileId, boardTile.TileId);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 2)]
        [InlineData(1, 2, 2)]
        [InlineData(0, 1, 2)]
        public void TestCheckAdjacentTile(int row, int column, int expectedValue)
        {
            int numberOfAdjacentTiles = 0;
            lanternsBoard.PlaceInitialLakeTile(lakeTile1, 0, 0);
            lanternsBoard.PlaceInitialLakeTile(lakeTile1, 2, 0);
            lanternsBoard.PlaceInitialLakeTile(lakeTile1, 0, 2);
            lanternsBoard.PlaceInitialLakeTile(lakeTile1, 2, 2);
            lanternsBoard.PlaceInitialLakeTile(lakeTile1, 2, 1);

            numberOfAdjacentTiles += lanternsBoard.CheckAdjacentTile(row - 1, column);
            numberOfAdjacentTiles += lanternsBoard.CheckAdjacentTile(row, column - 1);
            numberOfAdjacentTiles += lanternsBoard.CheckAdjacentTile(row + 1, column);
            numberOfAdjacentTiles += lanternsBoard.CheckAdjacentTile(row, column + 1);

            Assert.Equal(numberOfAdjacentTiles, expectedValue);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(1, 2)]
        public void TestPlacementWithAdjacentTiles(int row, int column)
        {
            lanternsBoard.PlaceInitialLakeTile(lakeTile3, 1, 1);
            Assert.True(lanternsBoard.PlaceLakeTileOnBoard(lakeTile2, row, column));
        }
    }
}
