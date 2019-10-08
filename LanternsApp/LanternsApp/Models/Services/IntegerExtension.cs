using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Services
{
    public static class IntegerExtension
    {
        public static bool IsEven(this int i)
        {

            return ((i % 2) == 0);
        }
    }
}
