using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int[] data = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                data[i] = rdn.Next(1, 10);
            }
            for (i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            Console.Write("3の倍数：");
            for (i = 0; i < data.Length; i++)
            {
                if (data[i] % 3 == 0)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();

            Console.Write("3の倍数以外の数");
            for (i = 0; i < data.Length; i++)
            {
                if (data[i] % 3 != 0)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
