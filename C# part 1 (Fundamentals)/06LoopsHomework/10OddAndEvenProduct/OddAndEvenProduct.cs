using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] inputMass = input.Split(' ');
            int[] massInInt = new int[n];
            for (int i = 0; i < inputMass.Length; i++)
            {
                massInInt[i] = int.Parse(inputMass[i]);
            }
            long oddProduct = 1;
            long evenProduct = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= massInInt[i];
                }
                else
                {
                    evenProduct *= massInInt[i];
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
            
        }
    }
}
