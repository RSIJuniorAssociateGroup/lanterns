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
        public string QuadrantZeroColor { get; set; }
        public string QuadrantOneColor { get; set; }
        public string QuadrantTwoColor { get; set; }
        public string QuadrantThreeColor { get; set; }
    }
}


