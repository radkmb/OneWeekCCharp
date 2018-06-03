using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;

            Console.Write("文字列１を入力:");
            str1 = Console.ReadLine();
            Console.Write("文字列２を入力:");
            str2 = Console.ReadLine();
            Console.WriteLine("文字列１＋文字列２＝{0}", str1 + str2);
        }
    }
}
