using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PlayCard
{
    class PlayCard
    {
        enum Cards
        {
            J,
            K
        }
        static void Main()
        {
            string input = Console.ReadLine();
            //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A
            switch (input)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    {
                        Console.WriteLine("yes {0}", input);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("no {0}", input);
                        break;
                    }
            }
        }
    }
}
