
/*
 * ############################################################################
 * ############################################################################
 * 
 *             WAP to input any Alphabet and and check whether the 
 *      Alphabet is UpperCase, LowerCase, Digit, Special Symbol or a Space.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper_Lower_Digit_SpecialSymbol_Space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Single Character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            // Checking for Upper Case Characters
            if (char.IsUpper(ch))
                Console.WriteLine("\n You entered an Upper Case Character.");

            // Checking for Lower Case Characters
            else if (char.IsLower(ch))
                Console.WriteLine("\n You entered a Lower Case Character.");

            // Checking for Digits
            else if (ch >= 48 && ch <= 57)
                Console.WriteLine("\n You entered a Digit.");

            // Checking for Spaces
            else if (ch == ' ')
                Console.WriteLine("\n You entered a Space.");

            // Checking for Special Symbols
            else
                Console.WriteLine("\n You entered a Special Symbol.");

            Console.ReadLine();
        }
    }
}
