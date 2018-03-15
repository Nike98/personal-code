/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program performs the task of Selection Sort
 * 
 * 		In Selection Sort the algorithm checks the 1st
 * 		element then compares it with the next element
 * 		if it is smaller then it is shifted to the left
 * 		(for ascending order) or as the previous element. 
 * 		The same goes on with the following elements.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class insert_sort {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();				// Getting the size of the Array input from the User
		
		int arr[] = new int[size];
		
		System.out.println("\n Enter the values in the Array : \n");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();			// Getting the values in the Array list input from the User
		}
		
		// Displaying the Scanned Array
		
		System.out.println("\n The Array Before getting Sorted... \n");
		
		for ( int loop : arr )
			System.out.print(" " + loop);
		
		InsertionSortAlgo(arr);
		
		// Displaying the Sorted Array
		
		System.out.println("\n\n The Array After getting Sorted... \n");
			
		for ( int loop : arr )
			System.out.print(" " + loop);
		
	}
	
	public static void InsertionSortAlgo(int[] arr) {
		
		int len = arr.length;
		
		for ( int j = 1 ; j < len ; j++ ) {
			
			int key = arr[j];			// Stores the current value of j in the variable key
			
			int i = j - 1;				// Initializes the value of i as the previous index of j
			
			/*
			 * Checks if i > -1 and the current value of 
			 * arr is greater than key.
			 * 
			 * if it is so then shift all the the current 
			 * elements to the right
			 */
			while ( (i > -1) && (arr[i] > key) ) {
				arr[i + 1] = arr[i];
				i--;
			}
			
			/*
			 * When all the elements are shifted to the right,
			 * the value stored in key (if smaller than others)
			 * is shifted to the current index.
			 */
			arr[i +1] = key;
		}
	}

}
