/*
Given a sorted array of distinct integers and a target value, 
return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.
You must write an algorithm with O(log n) runtime complexity.
Input: nums = [1,3,5,6], target = 5
Output: 2
*/

using System;
using System.Collections.Generic;
using System.Collections;

namespace SearchInsert
{
    public class Solution
    {
        public static int SearchInsert(int[] array, int target)
        {

            for (int i = 0; i < array.Length; i++)
            {              
                if (array[i] >= target)
                {
                    return i;
                }
            }
            
            return array.Length;    
        }
    }
}