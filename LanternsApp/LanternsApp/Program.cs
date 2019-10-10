using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using LanternsApp.Models.Classes;

namespace LanternsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            //Console.WriteLine("Here is the start");
            //Console.ReadLine();
            //LakeTile tile00 = new LakeTile(00, "red", "blue", "green", "yellow");
            //Console.WriteLine(tile00);
            //LakeTile.Dump(tile00);
            //Console.ReadLine();

            LanternsBoard board = new LanternsBoard(3, 3);
            LakeTile lTile = new LakeTile("r", "g", "b", "y");
            board.PlaceLakeTileOnBoard(lTile, 1, 1);
            board.PlaceLakeTileOnBoard(lTile, 0, 1);

            Console.WriteLine(board.Board.Find(tile => tile.Row == 0 && tile.Column == 1).TileId);
            Console.WriteLine(board.Board.Find(tile => tile.Row == 1 && tile.Column == 1).TileId);
            Console.ReadLine();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
