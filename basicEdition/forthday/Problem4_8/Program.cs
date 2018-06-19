using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_8
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("0以上の数値を入力してください:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);

                if (num < 0)
                {
                    break;
                }
            }
        }
    }
}
