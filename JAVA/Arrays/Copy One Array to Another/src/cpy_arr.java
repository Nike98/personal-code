/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to Copy one Array to Another Array
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class cpy_arr {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size : ");
		int size = inp.nextInt();					// Getting the Size of the Array input 
		
		int arr1[] = new int[size];		// Initializing the 1st Array 
		int arr2[] = new int[size];		// Initializing the 2nd Array
		
		System.out.println("\n Enter the Elements of the 1st Array : \n");
		for ( int i = 0 ; i < size ; i++ ) {
			arr1[i] = inp.nextInt();				// Input by the User
		}
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr2[i] = arr1[i];						// Copying the Array
		}
		
		System.out.println("\n The 2nd Array : \n");
		for ( int loop : arr2 ) {
			System.out.println(" " + loop);			// Displaying the new Array
		}
	}

}
