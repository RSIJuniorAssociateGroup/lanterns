using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class LanternsDedication
    {
        List<int> oneOfEach;
        List<int> threePair;
        List<int> fourOfAKind;

        public LanternsDedication(int numberOfPlayers = 4)
        {
            if (numberOfPlayers == 4)
            {
                oneOfEach = new List<int> { 5, 6, 7, 7, 8, 8, 9, 9, 10 };
                threePair = new List<int> { 5, 5, 6, 6, 7, 7, 8, 8, 9 };
                fourOfAKind = new List<int> { 4, 5, 5, 5, 6, 6, 7, 7, 8 };
            } else if (numberOfPlayers == 3)
            {
                oneOfEach = new List<int> { 5, 6, 7, 7, 8, 8, 9, 10 };
                threePair = new List<int> { 5, 5, 6, 6, 7, 7, 8, 9 };
                fourOfAKind = new List<int> { 4, 5, 5, 5, 6, 6, 7, 8 };
            } else if (numberOfPlayers == 2)
            {
                oneOfEach = new List<int> { 5, 6, 7, 8, 9, 10 };
                threePair = new List<int> { 5, 5, 6, 7, 8, 9 };
                fourOfAKind = new List<int> { 4, 5, 5, 6, 7, 8 };
            } else
            {
                throw new Exception("Improper amount of players");
            }
        }
    }
}
