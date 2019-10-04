using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class LakeTile
    {
        //Tile Id
        public int TileId { get; set; }

        //Tile Quadrant Colors
        public string ZeroColor { get; set; }
        public string OneColor { get; set; }
        public string TwoColor { get; set; }
        public string ThreeColor { get; set; }

        List<string> colorList = new List<string>();

        public LakeTile(int id, string colorZero, string colorOne, string colorTwo, string colorThree)
        {
            TileId = id;
            ZeroColor = colorZero;
            OneColor = colorOne;
            TwoColor = colorTwo;
            ThreeColor = colorThree;

            colorList.Add(ZeroColor);
            colorList.Add(OneColor);
            colorList.Add(TwoColor);
            colorList.Add(ThreeColor);
            Console.WriteLine(colorList);
        }

        public override string ToString()
        {
            return ZeroColor;
        }

        
        public static void Dump(object o)
        {
            string json = JsonConvert.SerializeObject(o, Formatting.Indented);
            Console.WriteLine(json);
        }

    }
}


