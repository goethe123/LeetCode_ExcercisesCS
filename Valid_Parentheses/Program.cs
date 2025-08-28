// Given a string s containing just the characters '(', ')', '{', '}'
//, '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.

using System;
using System.Collections.Generic;
namespace Valid_Parentheses
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("añade tu string a validar");
            string palabra = Console.ReadLine();
            Validacion(palabra);
            System.Console.Write(palabra);
        }

        public static void Validacion(string palabrilla)
        {
            Stack<char> StackAperturas = new Stack<char>();

            foreach (char simbolo in palabrilla)
            {
                if (simbolo == '(' || simbolo == '{' || simbolo == '[')
                {
                    StackAperturas.Push(simbolo);
                }
                else
                {
                    if (StackAperturas.Count == 0)
                    {
                        System.Console.WriteLine("todo maaaal ni hay simbolos de apertura");
                    }

                    char Top = StackAperturas.Pop();

                    if
                    (
                        (simbolo == ')' && Top != '(') ||
                        (simbolo == '}' && Top != '{') ||
                        (simbolo == ']' && Top != '[')
                    )
                    {
                        System.Console.WriteLine("neeel no son concluidos tus simbolos");
                    }
                }



            }
             if (StackAperturas.Count == 0)
                {
                    System.Console.WriteLine("todos los simbolos fueron cerrados!");
                }
                else
                {
                    System.Console.WriteLine("quedaron simbolos isn resolver");
                }
        }
    }
}
