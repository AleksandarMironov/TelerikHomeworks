using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main()
        {
            DateTime clock = DateTime.Now;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(clock.Hour + " : " + clock.Minute + " : " + clock.Second);
                Thread.Sleep(1000);
                clock = DateTime.Now;
            }
        }
    }
}
