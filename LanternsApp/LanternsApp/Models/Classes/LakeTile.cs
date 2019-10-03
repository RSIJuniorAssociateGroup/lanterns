using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile : IColor
    {
        //Tile Id
        public int TileId { get; set; }

        //Tile Quadrant Colors
        public string quadrantZeroColor { get; set; }
        public string quadrantOneColor { get; set; }
        public string quadrantTwoColor { get; set; }
        public string quadrantThreeColor { get; set; }

        // Orientation: Relevant only when being placed 
        // or is placed on the board therefore part of board object.
        //public int OrientationQuadrant { get; set; }

        // X & Y Coordinates: Again only relevant in relation to
        // the board
        //public int xCoordinate { get; set; }
        //public int yCoordinate { get; set; }
    }
}


