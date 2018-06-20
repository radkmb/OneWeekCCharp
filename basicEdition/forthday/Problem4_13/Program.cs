using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 1; i++)
            {
                int dise = rnd.Next(1,10);
                Console.WriteLine("発生した数値：" + dise);

                for (int a = 1; a <= dise; a++)
                {
                    if (dise >= 5)
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
