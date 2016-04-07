using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Age
{
    class Age
    {
        static void Main()
        {
            DateTime now = DateTime.Today;
            DateTime input = new DateTime();
            String.Format("MM.dd.yyyy", input);
            input = DateTime.Parse(Console.ReadLine());
           
            var intToCompare1 = Convert.ToInt32(input.ToString("yyyyMMdd"));
            var intToCompare2 = Convert.ToInt32(now.ToString("yyyyMMdd"));

            Console.WriteLine((intToCompare2 - intToCompare1)/10000);
            Console.WriteLine((intToCompare2 - intToCompare1) / 10000 + 10);


        }
    }
}
