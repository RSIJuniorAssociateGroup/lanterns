using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Services
{
    public class RotateTile
    {
        public static List<string> RotateTileRight(List<string> list)
        {
            string item = list[3];
            list.RemoveAt(3);
            list.Insert(0, item);
            return list;
        }
        public static List<string> RotateTileLeft(List<string> list)
        {
            string item = list[0];
            list.RemoveAt(0);
            list.Insert(3, item);
            return list;
        }
    }
}
