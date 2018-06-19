using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> rndList = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                int dice = rnd.Next(1, 100);
                Console.WriteLine(dice);
                rndList.Add(dice);
            }
            int min = rndList.Min();
            int max = rndList.Max();

            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値："　+ min);
        }
    }
}
