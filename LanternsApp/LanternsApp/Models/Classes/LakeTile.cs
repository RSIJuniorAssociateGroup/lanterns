using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile
    {
        //Count lake tiles
        public static int TotalTilesCreated { get; set; } = 0;

        //Tile Id
        public int TileId { get; set; }

        List<string> colorList = new List<string>();

        public LakeTile(string colorZero, string colorOne, string colorTwo, string colorThree)
        {
            if (!CanCreateTile())
            {
                throw new Exception("You cannot create any more tiles");
            }
            
            TotalTilesCreated++;
            TileId = TotalTilesCreated;
            
            colorList.Add(colorZero);
            colorList.Add(colorOne);
            colorList.Add(colorTwo);
            colorList.Add(colorThree);
            Console.WriteLine(colorList);
        }

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


