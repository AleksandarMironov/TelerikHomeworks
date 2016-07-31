using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new GenericList<int>(20);

            myList.Add(5);
            myList[0] = 6;
            myList.Add(8);
            Console.WriteLine(myList.IndexOf(6));
            Console.WriteLine(myList.ToString("-back front-"));

            myList.Remove(2);
            myList.Add(4);

            Console.WriteLine(myList.ToString());

            Console.WriteLine(myList.Min());
            Console.WriteLine(myList.Max());

            Console.WriteLine(myList.NextIndex);

            myList.Clear();
            Console.WriteLine(myList.ToString());
        }
    }
}
