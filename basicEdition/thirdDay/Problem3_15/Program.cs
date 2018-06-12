using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100)：");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 100)
            {
                if (num >= 80)
                {
                    Console.WriteLine("優");
                }
                else if (num < 80 && num >= 70)
                {
                    Console.WriteLine("良");
                }
                else if (num < 70 && num >= 60)
                {
                    Console.WriteLine("可");
                }
                else
                {
                    Console.WriteLine("不可");
                }
            }
            else
            {
                Console.WriteLine("範囲外です");
            }
        }
    }
}
