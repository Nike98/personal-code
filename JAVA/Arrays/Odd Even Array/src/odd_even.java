/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program takes input from the User in an Array 
 * 		and finds the Odd and Even values within it.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class odd_even {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();			// Getting the size of the Array input by the User
		
		int arr[] = new int[size];
		
		System.out.println(" Enter the " + " Elements of the Array : ");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();				// Getting the Elements of the Array input by the User
		}
		
		// Printing the Even Numbers
		System.out.println("\n The Even Numbers in the Array : \n");
		
		for ( int loop : arr ) {
			if ( loop % 2 == 0 )
				System.out.println(" " + loop);
		}
		
		// Printing the Odd Numbers
		System.out.println("\n The Odd Numbers in the Array : \n");
				
		for ( int loop : arr ) {
			if ( loop % 2 != 0 )
				System.out.println(" " + loop);
		}
	}

}
