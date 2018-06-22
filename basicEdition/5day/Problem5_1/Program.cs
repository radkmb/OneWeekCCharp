using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[7];

            for (int i = 0; i < a.Length; i++)
            {
                int dise = rnd.Next(1, 10);
                a[i] = dise;

                Console.WriteLine("a[" + i + "]" + "=" + a[i]);
            }
        }
    }
}
