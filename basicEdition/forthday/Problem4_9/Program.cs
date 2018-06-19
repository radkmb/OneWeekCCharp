using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                int a = rnd.Next(1, 100);
                Console.WriteLine(a);

                if (a % 10 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("終了します");
        }
    }
}
