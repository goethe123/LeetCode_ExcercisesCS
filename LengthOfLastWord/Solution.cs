/*Given a string s consisting of words and spaces, return the length of the last word in the string.
A word is a maximal substring consisting of non-space characters only.

Input: s = "Hello World_ _ "
Output: 5

*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace lengthOfLastWord
{
    public class Solution
    {
        public static int lengthOfLastWord(string word)
        {
            int i = word.Length - 1;
            int length = 0;

            while (i >= 0 && word[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && word[i] != ' ')
            {
                i--;
                length++;
            }
            return length;

        }
    }
}