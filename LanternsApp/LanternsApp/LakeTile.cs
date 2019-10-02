using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile : IColor
    {
        //public static SetGetLakeTile(string[] args)
        //{ 

        //Tile Id
        public int TileId { get; set; }

        //Tile Quadrant Colors
        public string TopColorQuadrant { get; set; }
        public string RightColorQuadrant { get; set; }
        public string BottomColorQuadrant { get; set; }
        public string LeftColorQuadrant { get; set; }

        //Orientation
        public int OrientationQuadrant { get; set; }

        //X & Y Coordinates
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
    //}
    }
}


