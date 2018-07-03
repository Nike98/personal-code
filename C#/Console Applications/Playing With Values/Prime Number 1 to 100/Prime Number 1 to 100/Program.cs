
/*
 * ############################################################################
 * ############################################################################
 * 
 *          WAP to print all the Prime Numbers between 1 to 100.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" The Prime Numbers Between 1 to 100 are : \n");

            bool isPrime = true;

            for (int i = 1; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine(" " + i);

                isPrime = true;
            }

            Console.ReadLine();
        }
    }
}
