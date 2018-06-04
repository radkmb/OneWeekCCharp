using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a <= 20 || a >= 80)
            {
                Console.WriteLine("20以下か80以上の値です");
            }
        }
    }
}
