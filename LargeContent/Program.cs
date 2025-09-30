// Takahashi has a bag and several items. 
// He wants to know if he can fit all the items in the bag without exceeding its size limit. 
// If the total size of the items is less than or equal to the bag's size, he can fit them all; 
// otherwise, he cannot.
// 5 15
// 3 1 4 1 5
// Output:
// Yes
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace LargeContent
{
    public class program
    {
        public static void Main(string[] args)
        {
            int BackpackSize = 15;
            System.Console.WriteLine("how many items do u have to store");
            int NItems = Convert.ToInt32(Console.ReadLine());
            int size = 0;
            for (int i = 0; i < NItems; i++)
            {
                System.Console.WriteLine("add the size of the item " + (i+1 )+ ":");
                int counter = Convert.ToInt32(Console.ReadLine());
                size += counter;
            }
            if (size <= BackpackSize)
            {
                System.Console.WriteLine($"everything has a size of {size}, so yes, it can be stored in your {BackpackSize} size backpack");
            }
            else
            {
                System.Console.WriteLine($"everything has a size of {size}, so yes, it can be stored in your {BackpackSize} size backpack");
            }
        }
    }
}
