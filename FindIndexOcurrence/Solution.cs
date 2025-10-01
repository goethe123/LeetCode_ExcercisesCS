/* Given two strings needle and haystack, 
return the index of the first occurrence of needle in haystack,
 or -1 if needle is not part of haystack.
 Input: haystack = "sadbutsad", needle = "sad"
Output: 0 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace FindIndexOcurrence
{
    public class Solution
    {
        public static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}