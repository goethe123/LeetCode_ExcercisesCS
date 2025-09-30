using System;
using System.Collections;
using System.Collections.Generic;

namespace removeElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numeros = [3, 2, 2, 3];
            int val = 3;

            System.Console.WriteLine(Solution.RemoveElement(numeros, val));
        }
    }
}
