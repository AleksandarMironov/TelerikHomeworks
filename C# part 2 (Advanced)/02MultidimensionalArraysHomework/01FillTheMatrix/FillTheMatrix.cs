using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            int[,] mass = new int[n, n];
            switch (ch)
            {
                case 'a':
                    {
                        int number = 1;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                mass[j, i] = number;
                                number++;
                            }
                        }

                        break;
                    }
                case 'b':
                    {
                        int number = 1;
                        for (int i = 0; i < n; i++)
                        {
                            if (i%2 == 0)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    mass[j, i] = number;
                                    number++;
                                }
                            }
                            else
                            {
                                for (int j = n-1; j >= 0; j--)
                                {
                                    mass[j, i] = number;
                                    number++;
                                }
                            }
                        }

                        break;
                    }
                case 'c':
                    {

                        break;
                    }
                case 'd':
                    {

                        break;
                    }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j]);
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
