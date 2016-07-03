using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                string sqrt = Math.Sqrt(number).ToString("F3");
                if (sqrt == "NaN")
                {
                    throw new System.FormatException();
                }
                Console.WriteLine(sqrt);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
