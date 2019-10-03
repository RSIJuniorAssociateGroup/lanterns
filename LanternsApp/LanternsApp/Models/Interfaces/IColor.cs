using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    interface IColor
    {
        string QuadrantZeroColor { get; set; }
        string QuadrantOneColor { get; set; }
        string QuadrantTwoColor { get; set; }
        string QuadrantThreeColor { get; set; }
    }
}
