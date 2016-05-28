using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            char[] firstMass = firstInput.ToCharArray();
            char[] secondMass = secondInput.ToCharArray();
            int dif = firstMass.Length - secondMass.Length;
            int answer = 0;
            if (dif < 0)
            {
                answer = 2;
            }
            else if (dif > 0)
            {
                answer = 1;
            }
            else if (dif == 0)
            {
                int len = (firstInput.Length >= secondMass.Length) ? secondMass.Length : firstInput.Length;
                for (int i = 0; i < len; i++)
                {
                    if (firstMass[i] != secondMass[i])
                    {
                        if (firstMass[i] > secondMass[i])
                        {
                            answer = 1;
                        }
                        else if (firstMass[i] < secondMass[i])
                        {
                            answer = 2;
                        }
                    }
                }
            }
            switch (answer)
            {
                case 0:
                    Console.WriteLine("=");
                    break;
                case 1:
                    Console.WriteLine(">");
                    break;
                case 2:
                    Console.WriteLine("<");
                    break;
            }

        }
    }
}
