using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _14IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(Minimum(numbers));
            Console.WriteLine(Maximum(numbers));
            Console.WriteLine(Average(Sum(numbers), numbers.Length));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));

        }
        //minimum, maximum, average, sum and product
        public static int Minimum(int[] arr)
        {
            int output = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < output)
                {
                    output = arr[i];
                }
            }
            return output;
        }

        public static int Maximum(int[] arr)
        {
            int output = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > output)
                {
                    output = arr[i];
                }
            }
            return output;
        }

        public static long Sum(int[] arr)
        {
            long output = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                output += arr[i];
            }
            return output;
        }

        public static string Average(long sum, int numberCount)
        {
            double output = sum*1.00/numberCount;

            return String.Format("{0:0.00}", output);
        }

        public static long Product(int[] arr)
        {
            long output = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                output *= arr[i];
            }
            return output;
        }

    }
}
