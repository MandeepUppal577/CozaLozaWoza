using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1, int end = 110;

            for (int i = start; i <= end; ++i)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Coza");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza");
                }

            }
        }
    }
}
