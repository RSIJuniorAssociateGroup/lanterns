using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    interface IColor
    {
        string TopColorQuadrant { get; set; }
        string RightColorQuadrant { get; set; }
        string BottomColorQuadrant { get; set; }
        string LeftColorQuadrant { get; set; }
    }
}
