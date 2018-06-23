
/*
 * ############################################################################
 * ############################################################################
 * 
 *              WAP to input a Character and Check whether 
 *               the Character is a Vowel or a Consonant.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrConsonant_Check
{
    class Vow_Consonant
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Single Character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                Console.WriteLine("\n The Character is a Vowel.");
            else if (ch > 0 || ch < 9)
                Console.WriteLine("\n A Number was Entered.");
            else
                Console.WriteLine("\n The Character is a Consonant.");

            Console.ReadLine();
        }
    }
}
