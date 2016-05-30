using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AppearanceCount
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(temp[i]);

            }
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Count(mass, number));

        }

        public static int Count(int[] mass, int number)
        {
            int counter = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == number)
                {
                    counter++;

                }
            }
            return counter;
        }
    }
}
