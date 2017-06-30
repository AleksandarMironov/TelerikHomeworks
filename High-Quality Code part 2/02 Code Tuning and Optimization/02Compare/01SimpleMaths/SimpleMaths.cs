using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SimpleMaths
{
    class SimpleMaths
    {
        //DRY it totally busted here, but didn't have time for better :)  

        public const int Repeats = 1000000;

        static void IntTest()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Int:");

            int intResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                intResult = 513 + 852;
            }
            timer.Stop();
            Console.WriteLine("Add: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                intResult = 852 - 513;
            }
            timer.Stop();
            Console.WriteLine("Subtract: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                intResult = 500 * 852;
            }
            timer.Stop();
            Console.WriteLine("Multiply: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                intResult = 852 / 19;
            }
            timer.Stop();
            Console.WriteLine("Divide: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                intResult++;
            }
            timer.Stop();
            Console.WriteLine("Increment: " + timer.Elapsed + Environment.NewLine);
            timer.Reset();
        }
        static void DoubleTest()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Double:");

            double doubleResult = 1.0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = 513.0 + 852.1;
            }
            timer.Stop();
            Console.WriteLine("Add: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = 852.0 - 513.1;
            }
            timer.Stop();
            Console.WriteLine("Subtract: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = 500.0 * 852.1;
            }
            timer.Stop();
            Console.WriteLine("Multiply: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult = 852 / 19.1;
            }
            timer.Stop();
            Console.WriteLine("Divide: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                doubleResult++;
            }
            timer.Stop();
            Console.WriteLine("Increment: " + timer.Elapsed);
            Console.WriteLine();
        }
        static void LongTest()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Long:");

            long longResult = 0;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                longResult = 513 + 852;
            }
            timer.Stop();
            Console.WriteLine("Add: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                longResult = 852 - 513;
            }
            timer.Stop();
            Console.WriteLine("Subtract: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                longResult = 500 * 852;
            }
            timer.Stop();
            Console.WriteLine("Multiply: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                longResult = 852 / 19;
            }
            timer.Stop();
            Console.WriteLine("Divide: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                longResult++;
            }
            timer.Stop();
            Console.WriteLine("Increment: " + timer.Elapsed + Environment.NewLine);
        }
        static void FloatTest()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Float:");

            float floatResult = 1.0f;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = 513.0f + 852.1f;
            }
            timer.Stop();
            Console.WriteLine("Add: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = 852.0f - 513.1f;
            }
            timer.Stop();
            Console.WriteLine("Subtract: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = 500.0f * 852.1f;
            }
            timer.Stop();
            Console.WriteLine("Multiply: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult = 852f / 19.1f;
            }
            timer.Stop();
            Console.WriteLine("Divide: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                floatResult++;
            }
            timer.Stop();
            Console.WriteLine("Increment: " + timer.Elapsed);
            Console.WriteLine();
        }
        static void DecimalTest()
        {
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("Decimal:");

            decimal decimalResult = 1.0m;
            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = 513.0m + 852.1m;
            }
            timer.Stop();
            Console.WriteLine("Add: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = 852.0m - 513.1m;
            }
            timer.Stop();
            Console.WriteLine("Subtract: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = 500.0m * 852.1m;
            }
            timer.Stop();
            Console.WriteLine("Multiply: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult = 852 / 19.1m;
            }
            timer.Stop();
            Console.WriteLine("Divide: " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < Repeats; i++)
            {
                decimalResult++;
            }
            timer.Stop();
            Console.WriteLine("Increment: " + timer.Elapsed);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            IntTest();
            LongTest();
            DoubleTest();
            FloatTest();
            DecimalTest();

        }
    }
}
