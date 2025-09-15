//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
//Given a roman numeral, convert it to an integer.
using System;
using System.Collections.Generic;

namespace RomanToInteger
{

    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("gove me ypur Roman Number");
            string Romano = Console.ReadLine();

            int result = RomanTranslation(Romano);
            Console.WriteLine($"The integer value is: {result}");
        }

        public static int RomanTranslation(string Romano)
        {
            Dictionary<char, int> Values = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };
            int Total = 0;
            for (int i = 0; i < Romano.Length; i++)
            {
                if (i + 1 < Romano.Length && Values[Romano[i]] < Values[Romano[i + 1]])
                {
                    Total = Total - Values[Romano[i]];
                }
                else
                {
                    Total = Total + Values[Romano[i]];
                }
            }
            return Total;
        }
    }
}

