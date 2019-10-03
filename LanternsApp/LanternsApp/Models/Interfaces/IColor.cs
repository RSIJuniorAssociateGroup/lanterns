using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    interface IColor
    {
        string quadrantZeroColor { get; set; }
        string quadrantOneColor { get; set; }
        string quadrantTwoColor { get; set; }
        string quadrantThreeColor { get; set; }
    }

}
