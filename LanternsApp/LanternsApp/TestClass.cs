using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp
{
    public class TestClass
    {
        public void TestLakeTile(string[] args)
        {
            var newTile = new LakeTile();

            Dump(newTile);

            Console.WriteLine("The following test will show a pass first and then a fail for a new LakeTile object. Click any key to continue.");
            Console.ReadLine();

            newTile.TopColorQuadrant = "Red";
            newTile.RightColorQuadrant = "White";
            newTile.BottomColorQuadrant = "Blue";
            newTile.LeftColorQuadrant = "Purple";

            newTile.TopQuadrant = 0;

            //Tile Id
            newTile.TileId=0;

            Dump(newTile);
 
            Console.WriteLine("Testing complete");
            Console.ReadLine();
        }
        private static void Dump(object o)
        {
            string json = JsonConvert.SerializeObject(o, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
