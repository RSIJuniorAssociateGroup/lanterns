using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class BoardTile
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int TileId { get; set; }

        public BoardTile(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public void ReceivedTile(LakeTile lakeTile)
        {
            TileId = lakeTile.TileId;
        }
    }
}
