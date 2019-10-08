using LanternsApp;
using LanternsApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LanternsAppTest.Tests
{
    public class LanternsBoardTileTest
    {
        private readonly LanternsBoardTile tile1 = new LanternsBoardTile(5, 1);
        private readonly LanternsBoardTile tile2 = new LanternsBoardTile(10, 10);

        private readonly LakeTile lakeTile1 = new LakeTile("red", "black", "blue", "purple");
        private readonly LakeTile lakeTile2 = new LakeTile("yellow", "yellow", "blue", "white");

        [Fact]
        public void TestLanternsBoardTileRow()
        {
            Assert.Equal(5, tile1.Row);
        }

        [Fact]
        public void TestLanternsBoardTileColumn()
        {
            Assert.Equal(1, tile1.Column);
        }
    }
}
