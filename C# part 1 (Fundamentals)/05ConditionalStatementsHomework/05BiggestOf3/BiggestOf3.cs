using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BiggestOf3
{
    class BiggestOf3
    {
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
            Console.WriteLine(inputList[inputList.Count-1]);
        }
    }
}
