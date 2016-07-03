using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Problem5
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int [] numbers = new int[m];
            for (int i = 0; i < m; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            string pString = Convert.ToString(p, 2);
            char[] perf = pString.ToCharArray();
            int len = perf.Length;
            for (int i = 0; i < m; i++)
            {
                char [] temp = Convert.ToString(numbers[i], 2).ToCharArray();
                for (int j = temp.Length - 1; j >= 0 + len-1 ; j--)
                {
                    bool kkk = true;
                    for (int k = 0; k < len; k++)
                    {
                        if (temp[j-k] != perf[len-1-k])
                        {
                            kkk = false;
                            break;
                        }
                        
                    }
                    if (kkk)
                    {
                        for (int k = 0; k < len; k++)
                        {
                            temp[j - k] = '0';
                        }
                    }
                }
                string ans = new string(temp);
                Console.WriteLine(Convert.ToInt32(ans,2));
            }
        }
    }
}
