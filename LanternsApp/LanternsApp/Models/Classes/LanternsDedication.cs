﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class LanternsDedication
    {
        private const int DefaultDedicationTokenValue = 4;

        public List<int> OneOfEach;
        public List<int> ThreePair;
        public List<int> FourOfAKind;

        public int OneOfEachIndex;
        public int ThreePairIndex;
        public int FourOfAKindIndex;

        public LanternsDedication()
        {
            OneOfEach = new List<int>();
            ThreePair = new List<int>();
            FourOfAKind = new List<int>();
        }

        public void SetListsByNumberOfPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 4)
            {
                OneOfEach.AddRange(new List<int>{ 5, 6, 7, 7, 8, 8, 9, 9, 10 });
                ThreePair.AddRange(new List<int> { 5, 5, 6, 6, 7, 7, 8, 8, 9 });
                FourOfAKind.AddRange(new List<int> { 4, 5, 5, 5, 6, 6, 7, 7, 8 });
            }
            else if (numberOfPlayers == 3)
            {
                OneOfEach.AddRange(new List<int> { 5, 6, 7, 7, 8, 8, 9, 10 });
                ThreePair.AddRange(new List<int> { 5, 5, 6, 6, 7, 7, 8, 9 });
                FourOfAKind.AddRange(new List<int> { 4, 5, 5, 5, 6, 6, 7, 8 });
            }
            else if (numberOfPlayers == 2)
            {
                OneOfEach.AddRange(new List<int> { 5, 6, 7, 8, 9, 10 });
                ThreePair.AddRange(new List<int> { 5, 5, 6, 7, 8, 9 });
                FourOfAKind.AddRange(new List<int> { 4, 5, 5, 6, 7, 8 });
            }
            else
            {
                throw new Exception("Invalid player number.");
            }

            OneOfEachIndex = OneOfEach.Count - 1;
            ThreePairIndex = ThreePair.Count - 1;
            FourOfAKindIndex = FourOfAKind.Count - 1;

        }

        public int GiveDedicationToPlayer(string dedicationType)
        {
            int result;

            switch(dedicationType)
            {
                case "OneOfEach":
                    if (OneOfEachIndex == -1)
                    {
                        result = DefaultDedicationTokenValue;
                        break;
                    }

                    result = OneOfEach[OneOfEachIndex];
                    OneOfEachIndex--;
                    break;

                case "ThreePair":
                    if (ThreePairIndex == -1)
                    {
                        result = DefaultDedicationTokenValue;
                        break;
                    }

                    result = ThreePair[ThreePairIndex];
                    ThreePairIndex--;
                    break;

                case "FourOfAKind":
                    if (FourOfAKindIndex == -1)
                    {
                        result = DefaultDedicationTokenValue;
                        break;
                    }

                    result = FourOfAKind[FourOfAKindIndex];
                    FourOfAKindIndex--;
                    break;

                default:
                    throw new Exception("Dedication type is not recognized");
            }

            return result;
        }
    }
}
