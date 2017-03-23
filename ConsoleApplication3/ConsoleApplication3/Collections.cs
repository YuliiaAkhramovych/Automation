using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Collections
    {
        static void Main()
        {
            Console.WriteLine("Enter any number from 1 to 12");
            var n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 12)
            {
                Console.WriteLine();
                Console.WriteLine("First " + n + " items");
                int[] mas = { 1, 2, 3, 47, 7, 25, 156, 11, 8, 147, 0, 245 };
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Last " + n + " items");
                for (int i = mas.Length - 1; i > mas.Length - 1 - n; i--)

                    Console.WriteLine(mas[i]);
            }
            else
            {
                Console.WriteLine("ALARM!!!");

            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit programm...");
            Console.ReadLine();
        }
    }
}
