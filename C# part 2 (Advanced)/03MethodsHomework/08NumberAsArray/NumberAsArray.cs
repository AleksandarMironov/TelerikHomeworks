using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08NumberAsArray
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            int[] arrSizes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(" ", SumArreys(arr1, arr2)));
        }

        public static List<int> SumArreys(int[] arr1, int[] arr2)
        {
            List<int> output = new List<int>();
            int[] largerMass = (arr1.Length >= arr2.Length) ? arr1 : arr2;
            int[] smallerMass = (arr1.Length >= arr2.Length) ? arr2 : arr1;
            int plusOne = 0;
            for (int i = 0; i < smallerMass.Length; i++)
            {
                int number = smallerMass[i] + largerMass[i] + plusOne;
                if (number > 9)
                {
                    number = number%10;
                    plusOne = 1;
                }
                else
                {
                    plusOne = 0;
                }
                output.Add(number);
            }
            for (int i = smallerMass.Length; i < largerMass.Length; i++)
            {       
                output.Add(largerMass[i] + plusOne);
                plusOne = 0;

            }
            return output;
        }
    }
}
