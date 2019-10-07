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
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
                        Console.WriteLine("Here is the start");
            Console.ReadLine();
            LakeTile tile00 = new LakeTile("red", "blue", "green", "yellow");
            JsonUtility.Dump(tile00);
        //Should return the tileId
        //If no t then it did not successfully assign colors to the newly created lake tile.
            Console.WriteLine();
            Console.ReadLine();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
