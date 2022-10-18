using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf_2
    { 
        public static void PrintValue()
        {
            int i, n;
            Console.WriteLine("\n\n");
            Console.WriteLine( "Display the multiplication table:\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Input the number for which you want to print the table : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} X {1} = {2} \n",n,i, n*1);
            }
            

        }
    }
}