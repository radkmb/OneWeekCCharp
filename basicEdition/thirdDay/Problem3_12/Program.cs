using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a != 0)
            {
                if (a < 1)
                {
                    Console.WriteLine("負の値です");
                }
                else
                {
                    Console.WriteLine("正の値です");
                }
            }
            else
            {
                Console.WriteLine("0です");
            }
        }
    }
}
