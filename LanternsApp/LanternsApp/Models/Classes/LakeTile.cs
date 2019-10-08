using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile
    {
        public int TileId { get; set; }

        // List of the 4 colors assigned to the tile
        public List<string> colorList { get; set; }

        // Constructor for creating a tile
        public LakeTile(string colorZero, string colorOne, string colorTwo, string colorThree)
        {
            colorList = new List<string>();

            ++TileId;

            colorList.Add(colorZero);
            colorList.Add(colorOne);
            colorList.Add(colorTwo);
            colorList.Add(colorThree);

        }
        public static List<string> RotateTileRight(List<string> list)
        {
            string item = list[3];
            list.RemoveAt(3);
            list.Insert(0, item);
            return list;
        }
        public static List<string> RotateTileLeft(List<string> list)
        {
            string item = list[0];
            list.RemoveAt(0);
            list.Insert(3, item);
            return list;
        }
    }
}


