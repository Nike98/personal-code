
/*
 * ############################################################################
 * ############################################################################
 * 
 *             WAP to print A to Z in Uppercase and Lowercase.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_to_Z_Uppercase_and_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t Uppercase \t Lowercase");
            Console.WriteLine();
            
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                // Printing the Uppercase Character first
                Console.Write("\t     " + ch);

                // Converting the Character in Lowercase and Printing it in the same line
                Console.WriteLine("\t\t     " + char.ToLower(ch));

                // Converting the Lowercase converted Chracter back to Uppercase
                char.ToUpper(ch);
            }

            Console.ReadLine();
        }
    }
}
