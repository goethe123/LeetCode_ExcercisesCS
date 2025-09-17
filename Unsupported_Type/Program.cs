// You have a list of numbers and a single number. You need to check if the single number is in the list.
//  If it is, you say 'Yes', and if it isn't, you say 'No'.
// 5
// 3 1 4 1 5
// 4
// Output:
// Yes

using System;
using System.Collections.Generic;

namespace Hamana
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 4, 1, 5 };
            System.Console.WriteLine("Tu array es \n");
            foreach (int i in array)
            {
                System.Console.Write(i + ",");
            }
            System.Console.WriteLine("intro duce tu target");
            int Target = Convert.ToInt32(Console.ReadLine());

            bool finded = Validate(array, Target);
    
            if (finded)
            {
                System.Console.WriteLine("Yes, esta en la posicion");
            }
            else
            {
                System.Console.WriteLine("No");
            }
          
            

        }

        public static bool Validate(int[] array, int Target)
        {
            
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Target)
                {
              
                    return true;
                }
            }
            return false;
        }
    }
}