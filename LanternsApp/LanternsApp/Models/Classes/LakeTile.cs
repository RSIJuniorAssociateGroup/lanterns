using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class LakeTile
    {
        public int TileId { get; set; }

        // List of the 4 colors assigned to the tile
        List<string> colorList = new List<string>();

        // Constructor for creating a tile
        public LakeTile(string colorZero, string colorOne, string colorTwo, string colorThree)
        {
            ++TileId;

            colorList.Add(colorZero);
            colorList.Add(colorOne);
            colorList.Add(colorTwo);
            colorList.Add(colorThree);

        }
    }
}


