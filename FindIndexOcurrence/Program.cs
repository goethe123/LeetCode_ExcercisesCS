using System;
using System.Collections;
using System.Collections.Generic;

namespace FindIndexOcurrence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string haystack = "sadbutsad", needle = "sad";
            System.Console.WriteLine(Solution.StrStr(haystack, needle));
        }
    }
}
