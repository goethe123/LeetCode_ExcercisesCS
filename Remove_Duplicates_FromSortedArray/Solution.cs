/*
-Given an integer array nums sorted in non-decreasing order,
-remove the duplicates in-place such that each unique element appears only once.
-The relative order of the elements should be kept the same. 
-Then return the number of unique elements in nums.

            [1,1,1,2,2,3,3,4]
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace practice
{
    public class Solution
    {
        public static int RemoveDuplicates(int[] Nums)
        {
            int i = 1;
            foreach (int n in Nums)
            {
                if (Nums[i - 1] != n)
                {
                    Nums[i] = n;
                    i++;
                }

            }
            return i;
        }
   }
}
