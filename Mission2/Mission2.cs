using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mission2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var file = File.ReadAllLines("mission2.txt");
            var total = SumAllLines(file);

            Console.WriteLine("The result is : " + total);
        }

        public static Dictionary<char, int> RomanCharEquivalent = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int RomanToInteger(string roman)
        {
            int number = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanCharEquivalent[roman[i]] < RomanCharEquivalent[roman[i + 1]])
                    number -= RomanCharEquivalent[roman[i]];
                else
                    number += RomanCharEquivalent[roman[i]];
            }

            return number;
        }

        public static int SumAllLines(string[] file)
        {
            int[] numberArray = new int[100000];

            for (int i = 0; i < file.Length; i++)
            {
                int number = RomanToInteger(file[i].Replace("-", string.Empty));

                numberArray[i] = number;
            };
      
            var total = numberArray.Sum();

            return total;       
        }
    }
}
