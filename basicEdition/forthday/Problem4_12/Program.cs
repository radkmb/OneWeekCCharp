using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int oddCount = 0;

            Random rnd = new Random();
            {
                for (int i = 0; i < 5; i++)
                {
                    int a = rnd.Next(1, 101);
                    Console.WriteLine(a);
                    if (a % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                Console.WriteLine("偶数は：" + evenCount);
                Console.WriteLine("奇数は：" + oddCount);
            }
        }
    }
}