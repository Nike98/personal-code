
/*
 * ############################################################################
 * ############################################################################
 * 
 *         WAP to Create a Console Application to accept five numbers 
 *              into an Array and Display the Square and Cube 
 *                     in the Second and Third Array.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storing_Square_and_Cube
{
    class MainProgClass
    {
        static void Main(string[] args)
        {
            int[] MainArray = new int[5];

            Console.WriteLine(" Please Enter 5 Elements within the Array : \n");

            // Getting Input from the User
            for (int i = 0; i < MainArray.Length; i++)
                MainArray[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n The Entered Array : \n");

            // Displaying the Entered Array to the User using the ForEach Loop
            foreach (int loop in MainArray)
                Console.WriteLine(" " + loop);

            /* Calling the DispSquare Class here which
             * has a Constructor handling the calculation 
             * of the Square of the values of the First Array
             * and display of the Second Array.
             */
            DispSquare objSquare = new DispSquare(MainArray);

            /* Calling the DispCube Class here which
             * has a Constructor handling the calculation 
             * of the Cube of the values of the First Array 
             * and display of the Third Array.
             */
            DispCube objCube = new DispCube(MainArray);

            Console.ReadLine();
        }
    }

    class DispSquare
    {
        public DispSquare(int[] arr)
        {
            int[] SecondArray = new int[5];

            // Calculating and Storing the Square of the First Array in the Second Array 
            for (int i = 0; i < arr.Length; i++)
                SecondArray[i] = Convert.ToInt32(Math.Pow(arr[i], 2));

            Console.WriteLine("\n The Second Array containing the Square of the values of the First Array : \n");

            // Displaying the Second Array containing the Square of the values of the First Array
            foreach (int loop in SecondArray)
                Console.WriteLine(" " + loop);
        }
    }

    class DispCube
    {
        public DispCube(int[] arr)
        {
            int[] ThirdArray = new int[5];

            // Calculating and Storing the Cube of the First Array in the Third Array 
            for (int i = 0; i < arr.Length; i++)
                ThirdArray[i] = Convert.ToInt32(Math.Pow(arr[i], 3));

            Console.WriteLine("\n The Third Array containing the Cube of the values of the First Array : \n");

            // Displaying the Third Array containing the Cube of the values of the First Array
            foreach (int loop in ThirdArray)
                Console.WriteLine(" " + loop);
        }
    }
}
