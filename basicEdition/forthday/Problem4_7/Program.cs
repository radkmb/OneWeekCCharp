using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 2; a <= 8; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("num=" + a);
                }
            }
        }
    }
}
