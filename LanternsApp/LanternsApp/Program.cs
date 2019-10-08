using System;
using Newtonsoft.Json;

namespace LanternsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();\
            Console.WriteLine("This Unit test has 4 parts, testing the rotation ability of the RorateTile methods. First we will create a lake tile to test on.");
            Console.WriteLine("Click enter to continue:");
            Console.ReadLine();
            LakeTile tile01 = new LakeTile("red", "blue", "green", "yellow");
            string result = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("In this first test we are rotating the tile to the right once.");
            LakeTile.RotateTileRight(tile01.colorList);
            string resultTwo = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(resultTwo);
            Console.WriteLine("The result should return the LakeTile with the new color order: yellow, red, blue and green.");
            Console.WriteLine("Click enter to continue to the next test:");
            Console.ReadLine();

            Console.WriteLine("This second test rotates the tile to the left once.");
            LakeTile.RotateTileLeft(tile01.colorList);
            string resultThree = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(resultThree);
            Console.WriteLine("The result should return the LakeTile with the new color order: red, blue, green and yellow.");
            Console.WriteLine("Click enter to continue to the next test:");
            Console.ReadLine();

            Console.WriteLine("This third test rotates the tile to the right 3 times and then once more to return it to it's original position.");
            LakeTile.RotateTileRight(tile01.colorList);
            LakeTile.RotateTileRight(tile01.colorList);
            LakeTile.RotateTileRight(tile01.colorList);
            string resultFour = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(resultFour);

            LakeTile.RotateTileRight(tile01.colorList);
            string resultFive = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(resultFive);

            Console.WriteLine("The end result should return the LakeTile with the original color order: red, blue, green and yellow.");
            Console.WriteLine("Click enter to continue to the next test:");
            Console.ReadLine();

            Console.WriteLine("This final test rotates the tile to the left 3 times and then once more to return it to it's original position.");
            LakeTile.RotateTileLeft(tile01.colorList);
            LakeTile.RotateTileLeft(tile01.colorList);
            LakeTile.RotateTileLeft(tile01.colorList);
            string resultSix = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(resultSix);

            LakeTile.RotateTileLeft(tile01.colorList);
            string resultSeven = JsonConvert.SerializeObject(tile01);
            Console.WriteLine(resultSeven);

            Console.WriteLine("The end result should return the LakeTile with the original color order: red, blue, green and yellow.");
            Console.WriteLine("Click enter to close window.");
            Console.ReadLine();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
