using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _11AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", SumInArrey(arr1, arr2)));
        }

        public static int[] SumInArrey(int[] arr1, int[] arr2)
        {
            int [] output = new int[arr1.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = arr1[i] + arr2[i];
            }
            return output;
        }
    }
}
