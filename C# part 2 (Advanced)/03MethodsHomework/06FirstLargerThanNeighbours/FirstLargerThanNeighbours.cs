using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(FirstLarger(numbers));
        }

        public static int FirstLarger(int[] mass)
        {
            int position = -1;
            for (int i = 1; i < mass.Length-1; i++)
            {
                if (mass[i] > mass[i - 1] && mass[i] > mass[i + 1])
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }
}
