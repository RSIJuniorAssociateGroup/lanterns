﻿using LanternsApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

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
        [InlineData(2, 2)]
        [InlineData(1, 2)]
        public void TestPlaceBoardTile(int row, int column)
        {
            lanternsBoard.PlaceLakeTileOnBoard(lakeTile2, row, column);
            var boardTile = lanternsBoard.Board.Find(tile => tile.Row == row && tile.Column == column);

            Assert.Equal(boardTile.TileId, lakeTile2.TileId);
        }

    }
}
