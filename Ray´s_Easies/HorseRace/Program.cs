// You have a number of horse races, and each race allows horses of a certain age or younger to compete.
//  You need to find out how many races a horse of a specific age can enter.

using System;
using System.Collections.Generic;

namespace HorseRace
{
    public class Program
    {
        public static void Main(String[] Args)
        {
            Console.WriteLine("How many Horses will enter the race");
            int HorseNumber = Convert.ToInt32(Console.ReadLine());
            List<int> numero = new List<int>();
            Console.WriteLine("How many loops will the race have");
            int loops = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < HorseNumber; i++)
            {
                Console.WriteLine($"number o loops completed by the horse {i + 1}: ");
                int vueltas = Convert.ToInt32(Console.ReadLine());
                numero.Add(vueltas);
            }
            int ganadores = 0;
            foreach (int vueltas in numero)
            {
                if (vueltas >= loops)
                {
                    ganadores++;
                }
            }
            System.Console.WriteLine("ganadores: " +ganadores);
        

        }
    }
}