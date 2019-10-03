using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LanternsApp.Models.Utilities;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LanternsApp
{
    public class Program
    {

        //Count lake tiles
        public static int TotalTilesCreated { get; set; } = 0;

        //Tile Id
        public int TileId { get; set; }

        //List<string> colorList = new List<string>();

        public void LakeTile(string colorZero, string colorOne, string colorTwo, string colorThree)
        {
            if (!CanCreateTile())
            {
                throw new Exception("You cannot create any more tiles");
            }

            TotalTilesCreated++;
            TileId = TotalTilesCreated;


            var colorList = new List<string>();
            colorList.Add(colorZero);
            colorList.Add(colorOne);
            colorList.Add(colorTwo);
            colorList.Add(colorThree);
            Console.WriteLine(colorList);
        }

        private bool CanCreateTile()
        {
            if (TotalTilesCreated <= 36)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            Console.WriteLine("Here is the start");
            Console.ReadLine();
            LakeTile tile00 = new LakeTile("red", "blue", "green", "yellow");
            JsonUtility.Dump(tile00);
            Console.WriteLine();
            Console.ReadLine();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
