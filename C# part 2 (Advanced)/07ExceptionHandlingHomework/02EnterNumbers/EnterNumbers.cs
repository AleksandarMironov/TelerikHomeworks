using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EnterNumbers
{
    class EnterNumbers
    {
        private static int strat = 1;
        private static int end = 100;

        public static bool ReadNumber(int startNum, int endNum)
        {
            if (!(startNum < endNum))
            {
                throw new SystemException();
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] mass = new int[12];
            string exceptionMessage = "Exception";
            mass[0] = strat;
            mass[11] = end;

            for (int i = 1; i < 11; i++)
            {
                try
                {
                    mass[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(exceptionMessage);
                }
            }

            StringBuilder str = new StringBuilder();

            str.Append("1 < ");
            try
            {
                for (int i = 1; i < 12; i++)
                {
                    if (ReadNumber(mass[i - 1], mass[i]))
                    {
                        str.Append(mass[i]);
                        if (i < 11)
                        {
                            str.Append(" < ");
                        }
                    }
                }
                Console.WriteLine(str.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine(exceptionMessage);
            }

        }
    }
}
