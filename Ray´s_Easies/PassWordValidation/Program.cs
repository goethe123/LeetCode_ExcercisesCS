// You need to check if a password made of lowercase letters is long enough. 
// The password must be at least a certain number of characters long. 
// If it is long enough, you say 'Yes'; if not, you say 'No'.

using System;
using System.Collections.Generic;
namespace Password
{
    public class Program
    {
        public static void Main(String[] args)
        {

            int passwordLength = 5;
            Console.WriteLine("add your password");
            string password = Console.ReadLine();

            int a = password.Length;
            if (a >= passwordLength)
            {
                System.Console.WriteLine("yes");
            }
            else
            {
                System.Console.WriteLine("no");
            }
        }
    }
}