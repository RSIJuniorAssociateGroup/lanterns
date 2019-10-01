using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile : IColor      
    {
        public string TopColorQuadrant { get; set; }
        public string RightColorQuadrant { get; set; }
        public string BottomColorQuadrant { get; set; }
        public string LeftColorQuadrant { get; set; }

        //Orientation
        public int TopQuadrant;

        //Tile Id
        public int TileId;
    }
}
