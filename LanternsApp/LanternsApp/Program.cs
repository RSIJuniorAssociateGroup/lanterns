using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LanternsApp.Models.Classes;
using LanternsApp.Models.Services;
using LanternsApp.Models.Utilities;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LanternsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();\
           /* Console.WriteLine("Here is the start");
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
            Console.WriteLine("Move items in the list right");*/
            Console.ReadLine();
            LakeTile tile01 = new LakeTile("redd", "blue", "green", "yellow");
            string result = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(result);
            int n = 2;

            if (n.IsEven())

                Console.WriteLine("The value of the integer is even.");
            Console.ReadLine();
            var results = RotateTile.RotateTileRight(tile01.colorList);
            result = RotateTile.RotateTileRight(tile01.colorList);
            string resultTwo = JsonConvert.SerializeObject(results);
            Console.WriteLine(resultTwo);
            Console.WriteLine(result);
            Console.ReadLine();
            
            //RotateTile.MoveItemAtIndexToFront(List<T>, 3);
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
