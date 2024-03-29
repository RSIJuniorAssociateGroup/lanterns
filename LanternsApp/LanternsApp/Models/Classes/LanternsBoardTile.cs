﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class LanternsBoardTile
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int TileId { get; set; }

        public LanternsBoardTile(int row, int column)
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
