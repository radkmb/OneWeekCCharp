using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (a >= 1 && a <= 10 && b >= 1 && b <= 10)
            {
                if (a > b)
                {
                    Console.WriteLine("aのほうが大きいです。");
                }
                else if (a < b)
                {
                    Console.WriteLine("bのほうが大きいです。");
                }
                else
                {
                    Console.WriteLine("等しいです");
                }
            }
            else
            {
                Console.WriteLine("範囲外です");
            }
        }
    }
}
