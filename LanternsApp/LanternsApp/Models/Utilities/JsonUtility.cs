using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Utilities
{
    //used to serialize an object. Not great for lists, try using JsonConvert.SerializeObject(object/var);
    public class JsonUtility
    {
        public static void Dump(object o)
        {
            string json = JsonConvert.SerializeObject(o, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
