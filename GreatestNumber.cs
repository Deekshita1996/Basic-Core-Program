﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class GreatestNumber
    {
        public static void FindNumber()
        {
            Console.WriteLine("Enter the 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3) 
             {
                Console.WriteLine("First number is Greater");
             }
             else if (n2 > n3 && n2 > n1) 
             {
                Console.WriteLine("Second number is Greater");
             }
             else
             {
                Console.WriteLine("Third number is Greater");
             }
        }
    }
}
