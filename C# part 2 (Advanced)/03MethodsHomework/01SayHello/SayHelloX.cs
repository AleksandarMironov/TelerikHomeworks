using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SayHello
{
    class SayHelloX
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, "  + name + "!");
        }
    }
}
