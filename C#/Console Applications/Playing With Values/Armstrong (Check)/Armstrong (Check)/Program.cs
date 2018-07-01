
/*
 * ############################################################################
 * ############################################################################
 * 
 *                 WAP to take any Number as Input and Check 
 *                 whether it is an Armstrong Number or Not.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong__Check_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Positive Integer Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num;

            int ans = 0;

            while (num > 0)
            {
                int digit = num % 10;
                ans += Convert.ToInt32(Math.Pow(digit, 3));
                num /= 10;
            }

            if (temp == ans)
                Console.WriteLine("\n It is an Armstrong Number.");
            else
                Console.WriteLine("\n It is Not an Armstrong Number.");

            Console.ReadLine();
        }
    }
}
