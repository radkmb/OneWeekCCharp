using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            while (a <= 8)
            {
                while (a % 2 == 0)
                {
                    Console.WriteLine("num=" + a);
                    a++;
                }
                a++;
            }
        }
    }
}
