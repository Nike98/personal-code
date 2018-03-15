/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program performs the task of Selection Sort
 * 
 * 		In Selection Sort the algorithm checks the element
 * 		of the previous index and checks whether it is 
 * 		smaller (for ascending order). If it is so then
 * 		it swaps it with that index.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class selec_sort {

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
		
		SelectionSortAlgo(arr);
		
		// Displaying the Sorted Array
		
		System.out.println("\n\n The Array After getting Sorted... \n");
				
		for ( int loop : arr )
			System.out.print(" " + loop);
				
	}
	
	public static void SelectionSortAlgo(int arr[]) {
		
		for ( int i = 0 ; i < arr.length ; i++ ) {
			
			int index = i;			// Getting the current index
			
			/*
			 * Here, the value of the next index of i is stored in the j variable and checked
			 * whether that value is less than the current index value.
			 * 
			 * If it is such then the value of the current index is swapped with the j index.
			 */
			for ( int j = i + 1 ; j < arr.length ; j++ ) {
				if ( arr[j] < arr[index] )		// For Descending order : if ( arr[j] > arr[index] )
					index = j;
				
				/*
				 * Algorithm to swap the value if the value at the 
				 * current index is smaller than the value at j. 
				 */
				int small_num = arr[index];
				arr[index] = arr[i];
				arr[i] = small_num;
			}
		}
		
	}

}
