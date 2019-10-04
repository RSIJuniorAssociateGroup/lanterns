using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LanternsApp.Models.Classes;
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
            Console.WriteLine("This first test successfully creates the 36th LakeTile");
            Console.ReadLine();
            try
            {
                LakeTile tile00 = new LakeTile("red", "blue", "green", "yellow");
                JsonUtility.Dump(tile00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            Console.WriteLine("This second test successfully shows an exception when trying to make too many LakeTiles");
            Console.ReadLine();
            try
            {
                LakeTile tile00 = new LakeTile("red", "blue", "green", "yellow");
                JsonUtility.Dump(tile00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            Console.WriteLine("This unit test successfully creates a Player");
            Console.ReadLine();
            Player player01 = new Player("Brandon");
            JsonUtility.Dump(player01);
            Console.ReadLine();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
