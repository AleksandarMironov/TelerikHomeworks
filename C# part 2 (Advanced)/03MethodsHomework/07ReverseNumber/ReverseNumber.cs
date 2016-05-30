using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverce(number));
        }

        public static string Reverce(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
            }
            return sb.ToString();
        }
    }

}
