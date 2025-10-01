using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchInsert
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int [] nums = [1,3,5,6];
            int target = 5;
            System.Console.WriteLine(Solution.SearchInsert(nums, target));
            

        }
    }
}