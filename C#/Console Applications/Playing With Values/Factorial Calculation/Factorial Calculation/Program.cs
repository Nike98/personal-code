
/*
 * ############################################################################
 * ############################################################################
 * 
 *                      WAP to input a Number from the 
 *                     User and Calculate it's Factorial.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Positive Integer Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            if (num == 1 || num == 0)
                Console.WriteLine("\n The Factorial = 1");
            else
            {
                for (int i = num; i >= 1; i--)
                    fact *= i;
            }

            Console.WriteLine("\n The Factorial = " + fact);

            Console.ReadLine();
        }
    }
}
