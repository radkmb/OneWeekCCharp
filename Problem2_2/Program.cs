using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, d = 4, e = 5;
            
            a += 2;
            b -= 1;
            c *= 3;
            d /= 2;
            e %= 2;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("e = {0}", e);
        }
    }
}
