﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile
    {
        public static int TotalTilesCreated { get; set; } = 0;

        public int TileId { get; set; }

        // List of the 4 colors assigned to the tile
        List<string> colorList = new List<string>();

        // Constructor for creating a tile
        public LakeTile(string colorZero, string colorOne, string colorTwo, string colorThree)
        {
            if (!CanCreateTile())
            {
                throw new Exception("You cannot create any more tiles, all 36 possible tiles have already been created.");
            }
            
            TotalTilesCreated++;
            TileId = TotalTilesCreated;
            
            colorList.Add(colorZero);
            colorList.Add(colorOne);
            colorList.Add(colorTwo);
            colorList.Add(colorThree);
        }

        // Insuring can legally create tile
        private bool CanCreateTile()
        {
            if (TotalTilesCreated <= 36)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}


