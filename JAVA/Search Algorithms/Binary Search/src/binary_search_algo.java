/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program performs the task of Binary Search
 * 
 * 		In Binary Search the algorithm divides the array
 * 		into two equal halves till it finds the
 * 		required element within the array.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class binary_search_algo {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();				// Getting the size of the Array input from the User
		
		int arr[] = new int[size];
		
		System.out.println("\n Enter the values in the Array : \n");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();			// Getting the values in the Array list input from the User
		}
		
		System.out.print("\n Enter the value to find : ");
		int search = inp.nextInt();			// Getting the value to find input from the User
		
		int first = 0;
		int last = size - 1;
		int middle = (first + last) / 2;
		
		while ( first <= last ) {
			/*
			 * in this if condition the search value is checked to
			 * be less then the middle index derived from the array.
			 * 
			 * if the the value of search is greater, than the first
			 * index of the array will be the index after the middle index.
			 */
			if ( arr[middle] < search )
				first = middle + 1;
			
			/*
			 * here in this condition if the value to search is found
			 * within the Array then the program terminates and
			 * the output is shown to the User.
			 */
			else if ( arr[middle] == search ) {
				System.out.println("\n Value " + search + " found at location " + (middle + 1));
				break;
			}
			
			/*
			 * if none of the conditions are executed, then
			 * the value of last will be reinitialized as the 
			 * middle - 1st index.
			 */
			else
				last = middle - 1;
			
			middle = (first + last) / 2;		// Re-initialization of the middle value
		}
		
		/*
		 * if nothing succeeds the code displays the following message
		 */
		if ( first > last )
			System.out.println("\n Value " + search + " is not present in the list");
	}

}
