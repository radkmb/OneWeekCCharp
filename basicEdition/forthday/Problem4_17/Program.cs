using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_17
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(new string('■', i));
                Console.Write(new string('□', 10 - i));
                Console.WriteLine();
            }
        }
    }
}
