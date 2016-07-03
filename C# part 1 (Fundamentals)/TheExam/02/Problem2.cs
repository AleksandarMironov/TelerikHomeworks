using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Problem2
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());
            int speedOfGroup = 0;
            int longestGr = 0;

            int[] input = new int[c];
            for (int i = 0; i < c; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int longestGrTemp = 1;
            int speedOfGroupTemp = input[0];

            for (int i = 1; i < c; i++)
            {
                if (input[i - 1] < input[i])
                {
                    speedOfGroupTemp = speedOfGroupTemp + input[i];
                    longestGrTemp++;
                    input[i] = input[i - 1];
                    if (i == c - 1)
                    {

                        if (longestGrTemp > longestGr)
                        {
                            speedOfGroup = speedOfGroupTemp;
                            speedOfGroupTemp = input[i];
                            longestGr = longestGrTemp;
                            longestGrTemp = 1;
                        }
                        else if (longestGrTemp == longestGr)
                        {
                            if (speedOfGroupTemp > speedOfGroup)
                            {
                                speedOfGroup = speedOfGroupTemp;
                            }
                            speedOfGroupTemp = input[i];
                            longestGrTemp = 1;
                        }
                        else
                        {
                            speedOfGroupTemp = input[i];
                            longestGrTemp = 1;
                        }
                    }
                }
                else
                {
                    
                    if (longestGrTemp > longestGr)
                    {
                        speedOfGroup = speedOfGroupTemp;
                        speedOfGroupTemp = input[i];
                        longestGr = longestGrTemp;
                        longestGrTemp = 1;
                    }
                    else if (longestGrTemp == longestGr)
                    {
                        if (speedOfGroupTemp > speedOfGroup)
                        {
                            speedOfGroup = speedOfGroupTemp;
                        }
                        speedOfGroupTemp = input[i];
                        longestGrTemp = 1;
                    }
                    else
                    {
                        speedOfGroupTemp = input[i];
                        longestGrTemp = 1;
                    }
                }
            }
            Console.WriteLine(speedOfGroup);
        }
    }
}
