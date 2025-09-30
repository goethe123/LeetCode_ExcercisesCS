// You are given the heads of two sorted linked lists list1 and list2.

// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

// Return the head of the merged linked list.
/*Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TwoLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] Array1 = new int[] { 1, 2, 4 };
            int[] Array2 = new int[] { 1, 3, 4 };

            int[] Array3 = NewArray(Array1, Array2);

            foreach (int i in Array3)
            {
                Console.Write(i + ",");
            }




        }

        public static int[] NewArray(int[] Array1, int[] Array2)
        {
            List<int> ResultingList = new List<int>();

            int i = 0;
            int j = 0;

            while (i < Array1.Length && j < Array2.Length)
            {
                if (Array1[i] <= Array2[j])
                {
                    ResultingList.Add(Array1[i]);
                    i++;
                }

                else
                {
                    ResultingList.Add(Array2[j]);
                    j++;
                }

            }
              while (i < Array1.Length)
            {
                ResultingList.Add(Array1[i]);
                i++;
            }


            while (j < Array2.Length)
            {
                ResultingList.Add(Array2[j]);
                j++;
                
            }
            

            
            return ResultingList.ToArray();
        }
    }
}