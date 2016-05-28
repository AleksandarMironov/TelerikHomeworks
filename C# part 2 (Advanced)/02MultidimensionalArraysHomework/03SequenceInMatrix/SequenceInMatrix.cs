using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nM = input.Split(' ');
            int n = int.Parse(nM[0]);
            int m = int.Parse(nM[1]);
            string[][] mass = new string[n][];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                mass[i] = input.Split(' ');
            }
            int maxSequence = 0;
            int maxTemp = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    for (int k = j + 1; k < m; k++)
                    {
                        if (mass[i][j] == mass[i][k])
                        {
                            maxTemp++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxTemp > maxSequence)
                    {
                        maxSequence = maxTemp;
                    }
                    maxTemp = 1;
                }
                maxTemp = 1;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (mass[j][i] == mass[k][i])
                        {
                            maxTemp++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxTemp > maxSequence)
                    {
                        maxSequence = maxTemp;
                    }
                    maxTemp = 1;
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        maxTemp = 1;
            //        int x = i;
            //        int y = j;
            //        while (x < n && y < m)
            //        {
            //            if (mass[i][j] == mass[x][y])
            //            {
            //                maxTemp++;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //            x++;
            //            y++;
            //        }
            //        if (maxTemp > maxSequence)
            //        {
            //            maxSequence = maxTemp;
            //        }

            //    }
            //}
    

                Console.WriteLine(maxSequence);
        }
    }
}

//taskkill /f /im name.exe
