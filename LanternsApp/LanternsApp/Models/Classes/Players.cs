
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class Player
    {
        public int PlayerId { get; set; } = 0;

        public string PlayerName { get; set; }

        //Takes in the LakeTile.TileId int
        List<int> lakeTileHand = new List<int>();


    }
}
