using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public static void NumbersRepositioning()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before swap a =  " + a +    "b =  " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a =  " + a +     "b =  " + b);
        }
    }
}
