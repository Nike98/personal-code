
/*
 * ############################################################################
 * ############################################################################
 * 
 *                  WAP to input Digits from the User and 
 *                   Count the Number of Digits Entered.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Number_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter some Digits : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (num != 0)
            {
                num /= 10;
                count++;
            }

            Console.WriteLine("\n The Number of Digits Entered = " + count);
            Console.ReadLine();
        }
    }
}
