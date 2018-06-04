using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列１を入力:");
            string a = Console.ReadLine();
            Console.Write("文字列２を入力:");
            string b = Console.ReadLine();

            if (a == b)
            {
                Console.WriteLine("２つの文字列は等しい");
            }
            else 
            {
                Console.WriteLine("２つの文字列は等しくない");
            }
        }
    }
}
