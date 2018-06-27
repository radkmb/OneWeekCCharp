using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] data = new int[10];
            int i;

            for (i = 0; i < data.Length; i++)
            {
                int dise = rnd.Next(1, 100);
                data[i] = dise;
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            Console.Write("50以上の数 ：");
            for (i = 0; i < data.Length; i++)
            {
                if (data[i] >= 50)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();

            Console.Write("50未満の数 ：");
            for (i = 0; i < data.Length; i++)
            {
                if (data[i] < 50)
                {
                    Console.Write(data[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}