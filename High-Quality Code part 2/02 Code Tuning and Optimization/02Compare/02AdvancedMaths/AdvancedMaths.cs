using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AdvancedMaths
{
    class AdvancedMaths
    {
        public const int Repeats = 1000000;

        static void SquareRootTests()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("square root:");

            decimal decimalResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = (decimal)Math.Sqrt(999);
            }
            timer.Stop();
            Console.WriteLine("Decimal: " + timer.Elapsed);
            timer.Reset();

            float floatResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = (float)Math.Sqrt(999);
            }
            timer.Stop();
            Console.WriteLine("Float: " + timer.Elapsed);
            timer.Reset();

            double doubleResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = Math.Sqrt(999);
            }
            timer.Stop();
            Console.WriteLine("Double: " + timer.Elapsed);

        }

        static void NaturalLogarithmTests()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Natural Logarithm:");

            decimal decimalResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = (decimal)Math.Log10(999);
            }
            timer.Stop();
            Console.WriteLine("Decimal: " + timer.Elapsed);
            timer.Reset();

            float floatResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = (float)Math.Log10(999);
            }
            timer.Stop();
            Console.WriteLine("Float: " + timer.Elapsed);
            timer.Reset();

            double doubleResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = Math.Log10(999);
            }
            timer.Stop();
            Console.WriteLine("Double: " + timer.Elapsed);
        }

        static void SinusTests()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Natural Logarithm:");

            decimal decimalResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = (decimal)Math.Sin(999);
            }
            timer.Stop();
            Console.WriteLine("Decimal: " + timer.Elapsed);
            timer.Reset();

            float floatResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = (float)Math.Sin(999);
            }
            timer.Stop();
            Console.WriteLine("Float: " + timer.Elapsed);
            timer.Reset();

            double doubleResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = Math.Sin(999);
            }
            timer.Stop();
            Console.WriteLine("Double: " + timer.Elapsed);
        }
        static void Main(string[] args)
        {
            SquareRootTests();
            Console.WriteLine();
            NaturalLogarithmTests();
            Console.WriteLine();
            SinusTests();
        }
    }
}
