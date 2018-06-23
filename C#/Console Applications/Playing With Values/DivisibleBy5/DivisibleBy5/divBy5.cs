
/*
 * ############################################################################
 * ############################################################################
 * 
 *              WAP to input an Integer Number and check 
 *                whether it is Divisible by 5 or not.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy5
{
    class divBy5
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                if (num % 5 == 0)
                    Console.WriteLine("\n The Number is Divisible by 5.");
                else
                    Console.WriteLine("\n The Number is Not Divisible by 5.");
            }
            else
                Console.WriteLine("\n Number out of bounds.");

            Console.ReadLine();

        }
    }
}
