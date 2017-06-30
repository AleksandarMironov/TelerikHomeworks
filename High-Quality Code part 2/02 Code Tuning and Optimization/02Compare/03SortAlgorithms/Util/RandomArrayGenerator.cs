using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SortAlgorithms.Util
{
    public class RandomArrayGenerator
    {
        public static int[] GenerateIntArray(int minValue, int maxValue)
        {
            Random randNum = new Random();
            int[] randomArray = Enumerable
                .Repeat(0, 5)
                .Select(i => randNum.Next(minValue, maxValue))
                .ToArray();

            return randomArray;
        }

        public static double[] GenerateDoubleArray(int minValue, int maxValue)
        {
            var array = GenerateIntArray(minValue, maxValue)
                .Select(x => (double)(x + 1.01))
                .ToArray();

            return array;
        }
    }
}
