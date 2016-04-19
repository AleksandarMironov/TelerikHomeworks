using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05Calculate_
{
    class Calculate
    {

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int number = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            int factorial = 1; // factorial must be int

            if (x == 0) // check
            {
                Console.WriteLine("Invalid input!  x != 0");
            }
            else
            {
                // Sum = 0!/X^0 + 1!/X^1 + 2!/X^2 + … + N!/X^N 

                // first way
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;

                    sum += factorial/Math.Pow(x, i);
                }

                // second way
                //double power = 1;
                //for (int i = 1; i <= number; i++)
                //{
                //    factorial *= i;
                //    power *= x;
                //    sum += (factorial / power);
                //}

                Console.WriteLine("{0:F5}", sum); // other way {0:0.00000}

            }
        }
    }
}
