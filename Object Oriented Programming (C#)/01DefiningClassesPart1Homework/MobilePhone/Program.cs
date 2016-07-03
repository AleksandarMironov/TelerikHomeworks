using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            GSMTest.Test();
            Console.WriteLine("********************************************************************");
            GSMCallHistoryTest.CallHistory();

            //didn't have time to organise classes in folders.... :(
        }
    }
}
