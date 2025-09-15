/*Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".
Input: strs = ["flower","flow","flight"]
Output: "fl"
*/

using System;
using System.Collections.Generic;

namespace longest_Common_Prefix
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            string[] palabras = new string[] { "flower", "flow", "flight" };
            System.Console.WriteLine(CommonPrefix(palabras));
        }

        public static string CommonPrefix(string[] palabras)
        {
            string prefix = palabras[0];
            for (int i = 1; i < palabras.Length; i++)
            {
                while (palabras[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                    {

                        return "";
                    }
                }
            }
            return prefix;
        }

    }
}