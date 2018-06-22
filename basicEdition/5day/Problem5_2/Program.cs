using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[4];

            d[0] = 0.2;
            d[1] = -5.1;
            d[2] = 3.2;
            d[3] = 1.8;

            for (int i = 0; i < d.Length; i++)
            {
                Console.Write("a[" + i + "]" + "=" + d[i] + " ");
            }
        }
    }
}
