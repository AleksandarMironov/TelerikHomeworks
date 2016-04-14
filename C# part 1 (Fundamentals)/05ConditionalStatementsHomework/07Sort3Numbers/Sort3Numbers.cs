using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Sort3Numbers
{
    class Sort3Numbers
    {
        //Use nested if statements.

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            List<double> inputList = new List<double>();
            inputList.Add(a);
            inputList.Add(b);
            inputList.Add(c);

            inputList.Sort();

            Console.Write(inputList[2] + " ");
            Console.Write(inputList[1] + " ");
            Console.Write(inputList[0]);

        }
    }
}
