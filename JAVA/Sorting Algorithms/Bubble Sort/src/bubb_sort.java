/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program performs the task of Bubble Sort
 * 
 * 		In Bubble Sort the algorithm swaps the values with
 * 		small values first (as in ascending order) or as
 * 		greatest value first (as in descending order).
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class bubb_sort {

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
		
		System.out.println("\n The Array before getting Sorted... \n");
				
		for ( int loop : arr )
			System.out.print(" " + loop);
		
		// Logic
		for ( int i = 0 ; i < (size - 1) ; i++ ) {
			for ( int j = 0 ; j < size - i - 1 ; j++ ) {
				// For Ascending order use						// For Descending order use
				if ( arr[j] > arr[j + 1] ) {					//if ( arr[j] < arr[j + 1] ) {
					int swap = arr[j];								//int swap = arr[j];
					arr[j] = arr[j + 1];							//arr[j] = arr[j + 1];
					arr[j + 1] = swap;								//arr[j + 1] = swap;	
				}
			}
		}
		
		// Displaying the List of Accordingly Sorted Array Elements
		System.out.println("\n Sorted List of the Array : \n");
		
		for ( int loop : arr ) {
			System.out.println(" " + loop);
		}
	}

}
