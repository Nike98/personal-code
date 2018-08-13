
/*
 * ############################################################################
 * ############################################################################
 * 
 *                              Linear Search
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear_Search
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            // Getting the Size of the Array Entered by the User
            Console.Write(" Enter the Size of the Array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initializing the Array with the Size specified by the User
            int[] arr = new int[size];
            int i;

            // Storing values within the Array by the User
            Console.WriteLine("\n Enter " + size + " values within the Array: ");
            for (i = 0; i < size; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter the Value to be Checked : ");
            int value = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < size; i++)
            {
                /*
                 * If the value to search is found then
                 * the code will generate the following output
                 */
                if (arr[i] == value)
                {
                    Console.WriteLine("\n The Value " + value + " Exists at index no. " + (i + 1));
                    break;
                }
            }

            /*
             * If the value entered to search is out of bounds
             * or is non existent within the Array then 
             * the following code will be executed
             */
            if (i == size)
            {
                Console.WriteLine("\n The Value does not Exist");
            }

            Console.ReadLine();
        }
    }
}
