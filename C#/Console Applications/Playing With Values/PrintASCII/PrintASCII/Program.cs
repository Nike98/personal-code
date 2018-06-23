
/*
 * ############################################################################
 * ############################################################################
 * 
 *         WAP to input any character and Print it's ASCII value.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Single Character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n The ASCII value of the Character is : " + Convert.ToInt32(ch));

            Console.ReadLine();
        }
    }
}
