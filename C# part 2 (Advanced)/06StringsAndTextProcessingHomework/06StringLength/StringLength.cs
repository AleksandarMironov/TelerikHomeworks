using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Console.ReadLine().Replace("\\", string.Empty).PadRight(20, '*')).Substring(0,20));
        }
    }
}
