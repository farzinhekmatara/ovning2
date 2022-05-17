using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    internal static class Myconsole
    {

        public static string GetMeny()
        {
            Console.WriteLine("**Welkommen till huvudmenyn**\n" +
                "1. Inormation om biljettpris\n" +
                "2. Köp Biljetter\n" +
                "3. Skriv en text för att loopas\n" +
                "4. Skriv tre meningar med mellanslag mellan\n" +
                "0. Avsluta");
            string name = Console.ReadLine();
            return name;
        }

        public static uint NumberInput()
        {
            uint ageInNumber;
            do
            {
                Console.WriteLine("Skriv ålder");
                string answer = Console.ReadLine();
                if (uint.TryParse(answer, out ageInNumber))
                {
                    return ageInNumber;
                }

            } while (true);
        }



        public static void PrintMyString()
        {
            Console.WriteLine("Skriv en text");
            string text = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {i + 1}:{text}");
            }
            Console.Write($"\n");
        }

        public static void PrintInfo(string text)
        {
            Console.WriteLine($"{text}");
        }

    }
}
