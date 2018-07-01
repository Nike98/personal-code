
/*
 * ############################################################################
 * ############################################################################
 * 
 *                  WAP to input a number from the User 
 *                    and Print it in Reverse Order.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter an Integer Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int revnum = 0;

            while (num != 0)
            {
                revnum *= 10;
                revnum += num % 10;
                num /= 10;
            }

            Console.WriteLine("\n The Reversed Number = " + revnum);

            Console.ReadLine();
        }
    }
}
