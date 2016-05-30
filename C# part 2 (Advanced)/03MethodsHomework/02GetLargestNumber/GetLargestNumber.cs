using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] mass = input.Split(' ');
            int max = int.MinValue;
            for (int i = 0; i < mass.Length; i++)
            {
                max = GetMax(max, int.Parse(mass[i]));
            }
            Console.WriteLine(max);

        }

        public static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
