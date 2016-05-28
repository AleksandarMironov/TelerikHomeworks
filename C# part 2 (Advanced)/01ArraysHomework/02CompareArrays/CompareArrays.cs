using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double [] firstArray = new double[n];
            double [] secondArray = new double[n];
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = double.Parse(Console.ReadLine());
            }

            bool areEqual = true;

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
            string answer = areEqual ? "Equal" : "Not equal";
            Console.WriteLine(answer);
        }
    }
}
