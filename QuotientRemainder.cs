using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientRemainder
    {
        public static void GetQuotientRemainder()
        {
            int dividend, divisor;
            Console.WriteLine("Please enter the divident: ");
            dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the divisor");
            divisor = int.Parse(Console.ReadLine());
            int quotient = dividend/ divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}");
            Console.WriteLine("Quotient =" + quotient);
            Console.WriteLine("remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
