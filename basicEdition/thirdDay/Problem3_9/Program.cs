using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力:");
            string a = Console.ReadLine();

            if (a == "abc")
            {
                Console.WriteLine("abcです");
            }
            else
            {
                Console.WriteLine("abcではありません");
            }
        }
    }
}
