// Given an integer x, return true if x is a palindrome, and false otherwise.
using System;
using System.Collections.Generic;


namespace Palindrome
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string Numero = "121";

            if (PalindromeValidation(Numero))
            {
                System.Console.WriteLine($"the number {Numero} is in fact a palindrome");
            }
            else
            {
                 System.Console.WriteLine($"the number {Numero} is in Not a palindrome");
            }

        }

        public static bool PalindromeValidation(string Numero)
        {
           
            char[] caracteres = Numero.ToCharArray();
            char[] reverso = caracteres.Reverse().ToArray();

            return caracteres.SequenceEqual(reverso);

        }


    }
}

