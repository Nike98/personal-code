
/*
 * ############################################################################
 * ############################################################################
 * 
 * 		       This program performs the task of Binary Search
 * 
 * 		       In Binary Search the algorithm divides the array
 * 		       into two equal halves till it finds the
 * 		       required element within each of the divided arrays.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            // Getting the Size of the Array Entered by the User
            Console.Write(" Enter the Size of the Array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initializing the Array with the Size specified by the User
            int[] arr = new int[size];

            // Storing values within the Array by the User
            Console.WriteLine("\n Enter " + size + " values within the Array: ");
            for (int i = 0; i < size; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter the Value to be Checked : ");
            int search = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int last = size - 1;
            int middle = (first + last) / 2;

            while (first <= last)
            {
                /* in this if condition the search value is checked to
                 * be less then the value at the middle index derived 
                 * from the array.
                 * 
                 * if the the value of search is greater, then the first
                 * index of the array will be the index after the middle index.
                 */
                if (arr[middle] < search)
                    first = middle + 1;

                /* here in this condition if the value to search is found
                 * within the Array then the program terminates and
                 * the output is shown to the User.
                 */
                else if (arr[middle] == search)
                {
                    Console.WriteLine("\n Value " + search + " found at location " + (middle + 1));
                    break;
                }

                /*
                 * if none of the conditions are executed, then
                 * the value of last will be reinitialized as the 
                 * middle - 1st index.
                 */
                else
                    last = middle - 1;

                middle = (first + last) / 2;        // Re-initialization of the middle value
            }

            /*
             * if nothing succeeds the code displays the following message
             */
            if (first > last)
                Console.WriteLine("\n Value " + search + " is not present in the list");


            Console.ReadLine();
        }
    }
}
