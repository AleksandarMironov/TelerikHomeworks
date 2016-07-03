using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        public static void CallHistory()
        {
            Gsm callTest = new Gsm("Histery test model", "Unknown");
            callTest.AddCall(DateTime.Now, "0878564759", 360);
            callTest.AddCall(new DateTime(2016, 6, 6, 12, 35, 10), "0875658555", 58);
            callTest.AddCall(new DateTime(2016, 7, 6, 20, 10, 32), "0958264852", 33);

            Console.WriteLine("Call history:");
            Console.WriteLine(callTest.CallHistory);
            Console.WriteLine();

            Console.WriteLine("Total price of calls:");
            Console.WriteLine("{0:F2} BGN", callTest.GetPrice());
            Console.WriteLine();

            callTest.RemoveLongestCall();
            Console.WriteLine("Remove Longest Call!");
            Console.WriteLine();
            Console.WriteLine("New total price of calls:");
            Console.WriteLine("{0:F2} BGN", callTest.GetPrice());
            Console.WriteLine();

            callTest.ClearHistory();
            Console.WriteLine(callTest.CallHistory);
        }
    }
}
