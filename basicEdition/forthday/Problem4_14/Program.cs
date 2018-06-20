using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("発生した数値：");

            for (int i = 1; i <= 1; i++)
            {
                int dise = rnd.Next(1, 10);
                Console.WriteLine(dise);

                for (int a = 1; a <= dise; a++)
                {
                    if (dise % 2 == 0)
                    {
                        Console.Write("★");
                    }
                    else
                    {
                        Console.Write("☆");
                    }
                }
            }
        }
    }
}
