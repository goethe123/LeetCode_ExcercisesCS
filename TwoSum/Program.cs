// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace TwoSum
{
    // public class Program
    // {
    //     public static void Main(String[] args)
    //     {
    //         int[] arrayts = new int[] { 2, 7, 11, 15 };
    //         int target = 9;
    //         FindIndices(arrayts, target);


    //     }

    //     public static int[] FindIndices(int[] arraysillo, int Target)
    //     {
    //         for (int i = 0; i < arraysillo.Length; i++)
    //         {
    //             for (int j = i + 1; j < arraysillo.Length; j++)
    //             {
    //                 if (arraysillo[i] + arraysillo[j] == Target)
    //                 {
    //                     Console.WriteLine($"los indices que dan {Target} son {i}, {j}");
    //                     return new int[] { i, j };
    //                 }
    //             }
    //         }
    //         return Array.Empty<int>();
    //     }
    // }

        public class Solution
        
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j > i; i--)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indices.Add(i);
                        indices.Add(j);
                        return indices.ToArray();
                    }
                }
            }
             return new int[0];
        }
    }
}