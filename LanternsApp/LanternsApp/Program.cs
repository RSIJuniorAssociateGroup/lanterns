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
<<<<<<< HEAD
            //CreateWebHostBuilder(args).Build().Run();\
=======
            //CreateWebHostBuilder(args).Build().Run();
            Console.WriteLine("This unit test successfully creates a Player");
            Console.ReadLine();
            Player player01 = new Player("Brandon");
            JsonUtility.Dump(player01);
            Console.ReadLine();
>>>>>>> 512c0821b6908d402410713cf5ae696c5a45d976
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
