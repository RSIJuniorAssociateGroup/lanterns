using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public static class LanternsDedication
    {
        public static List<int> OneOfEach { get; private set; }
        public static List<int> ThreePair { get; private set; }
        public static List<int> FourOfAKind { get; private set; }

        public static void SetNumberOfTokensByPlayerCount(int numberOfPlayers)
        {
            if (numberOfPlayers == 4)
            {
                OneOfEach = new List<int> { 5, 6, 7, 7, 8, 8, 9, 9, 10 };
                ThreePair = new List<int> { 5, 5, 6, 6, 7, 7, 8, 8, 9 };
                FourOfAKind = new List<int> { 4, 5, 5, 5, 6, 6, 7, 7, 8 };
            }
            else if (numberOfPlayers == 3)
            {
                OneOfEach = new List<int> { 5, 6, 7, 7, 8, 8, 9, 10 };
                ThreePair = new List<int> { 5, 5, 6, 6, 7, 7, 8, 9 };
                FourOfAKind = new List<int> { 4, 5, 5, 5, 6, 6, 7, 8 };
            }
            else if (numberOfPlayers == 2)
            {
                OneOfEach = new List<int> { 5, 6, 7, 8, 9, 10 };
                ThreePair = new List<int> { 5, 5, 6, 7, 8, 9 };
                FourOfAKind = new List<int> { 4, 5, 5, 6, 7, 8 };
            }
        }
    }
}
