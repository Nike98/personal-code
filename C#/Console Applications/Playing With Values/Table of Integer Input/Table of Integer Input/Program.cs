
/*
 * ############################################################################
 * ############################################################################
 * 
 *          WAP to input a Positive Integer and Print it's Table.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_of_Integer_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Positive Integer : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (num > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int ans = num * i;
                    Console.WriteLine(" " + num + " x " + i + " = " + ans);
                }
            }
            else
                Console.WriteLine(" Wrong Input.");

            Console.ReadLine();
        }
    }
}
