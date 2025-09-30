// You need to count how many days Takahashi did more tasks than he planned.
// For each day, compare the number of tasks he actually completed with his goal and keep track of the days he succeeded.

// Input:
// 4
// 2 8
// 5 5
// 5 4
// 6 7
// Output:
// 2


using System;
using System.Collections.Generic;
namespace Task_Counter
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("How many days with task you did this week?");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the succeded tasks were: " + Validation(days));

        }

        public static int Validation(int Days)
        {
            int succeeded = 0;
            for (int i = 0; i < Days; i++)
            {
                 Console.WriteLine("Tasks Completed on  day " + (i+1) + ":");
                int Completed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Goal day " + (i+1) + ":");
                int Goal = Convert.ToInt32(Console.ReadLine());
               

                if (Completed >= Goal)
                {
                    succeeded += 1;
                }

            }
            return succeeded;
        }
    }
}