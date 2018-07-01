
/*
 * ############################################################################
 * ############################################################################
 * 
 *              WAP to input a String and Count the Number of 
 *        Vowels, Consonants, Digits, Special Symbols or Spaces in it.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowels_and_Consonants_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a String: ");
            String str = Convert.ToString(Console.ReadLine());

            int vowel = 0, consonant = 0, digits = 0, specialsym = 0, spaces = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                   vowel++;
                else if ((ch >= 'a' || ch >= 'A') && (ch <= 'z' || ch <= 'Z'))
                    consonant++;
                else if (ch >= 48 && ch <= 57)
                    digits++;
                else if (ch == ' ')
                    spaces++;
                else
                    specialsym++;
            }

            Console.WriteLine("\n The Number of  Vowels = " + vowel);
            Console.WriteLine(" The Number of Consonants = " + consonant);
            Console.WriteLine(" The Number of Digits = " + digits);
            Console.WriteLine(" The Number of Special Symbols = " + specialsym);
            Console.WriteLine(" The Number of Spaces = " + spaces);

            Console.ReadLine();
        }
    }
}
