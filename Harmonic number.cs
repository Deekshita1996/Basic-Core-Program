using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Harmonic_number
    {
        public static void NthNumber()
        {
            int i, n;
            double d = 0.0;
            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                d += 1 / (double)i;
            }
            Console.WriteLine("\nSum of series upto {0} terms : {1} \n", n, d);

        }
    }
}
