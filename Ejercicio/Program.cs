//limpiar un array

using System;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("ingresa los espacios de tu array");
            int espacios = Convert.ToInt32(Console.ReadLine());
            int[] arraysillo = new int[espacios];
            for (int i = 0; i < arraysillo.Length; i++)
            {
                System.Console.WriteLine("añade la posición " + i);
                int valor = Convert.ToInt32(Console.ReadLine());
                arraysillo[i] = valor;
            }
            Print2(arraysillo);
        }

        public static int LimpiarArray(int[] array)
        {
            int actualUnico = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[actualUnico])
                {
                    actualUnico++;
                    array[actualUnico] = array[i];
                }

            }

            return actualUnico + 1;
        }

        public static void Print2(int[] Array)
        {
            System.Console.WriteLine($"tu array original era: ");
            foreach (int i in Array)
            {
                System.Console.Write(i + ", ");
            }
            System.Console.WriteLine($"tu array ahora es: ");
            LimpiarArray(Array);
             foreach (int i in Array)
            {
                System.Console.Write(i + ", ");
            }

        }
    }
}