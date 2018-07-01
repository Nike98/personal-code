
/*
 * ############################################################################
 * ############################################################################
 * 
 *          WAP to input a Character and Check whether it is 
 *          UpperCase or LowerCase. If it is UpperCase then 
 *              Convert it to LowerCase and Vice Versa.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Single Character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (char.IsUpper(ch))
            {
                Console.WriteLine("\n It is an Upper Case Character.");
                Console.WriteLine(" The Character in Lower Case => " + char.ToLower(ch));
            }
            else
            {
                Console.WriteLine("\n It is a Lower Case Character.");
                Console.WriteLine(" The Character in Upper Case => " + char.ToUpper(ch));
            }

            Console.ReadLine();
        }
    }
}
