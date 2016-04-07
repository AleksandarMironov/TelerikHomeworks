using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string nString = n.ToString();
            if (nString.Length < 3)
            {
                Console.WriteLine("false 0");
            }
            else
            {
                int check = int.Parse(nString[nString.Length - 3].ToString());
                if (check == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}", check);
                }
            }
        }
    }
}
