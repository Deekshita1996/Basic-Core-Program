using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public static void GetVariation()
        {
            int n, v;
            Console.WriteLine("Please enter the number:  ");
            v = int.Parse(Console.ReadLine());
            for (n = 0; n < 1; n++)
            {
                if ( v % 2 == 0)
                {
                    Console.WriteLine("It is an Even number");
                }
                else
                {
                    Console.WriteLine("It is an Odd number");
                }
            }
        }
    }
}
