using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Uri url = new Uri(input);
            string protocol = url.Scheme;
            string server = url.Host;
            string resource = url.LocalPath;

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);
        }
    }
}
