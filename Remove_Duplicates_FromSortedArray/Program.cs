using System;
using System.Collections;
using System.Collections.Generic;


namespace practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = [1, 1, 1, 2, 2, 3, 3, 4];
            System.Console.WriteLine(Solution.RemoveDuplicates(array));
            foreach (int i in array)
            {
                System.Console.Write(i + ",");
            }
                   
        }
    }
}