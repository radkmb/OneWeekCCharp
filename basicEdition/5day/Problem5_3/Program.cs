using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                n[i] = rnd.Next(1, 101);
            }

            for (i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();

            Console.Write("奇数:");
            for (i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                {
                    Console.Write(n[i] + " ");
                }
            }
            Console.WriteLine();

            Console.Write("偶数:");
            for (i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    Console.Write(n[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}