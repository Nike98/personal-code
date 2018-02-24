/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program takes input from the User in an Array 
 * 		and finds the Minimum and Maximum values within it.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class min_max {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();			// Getting the size of the Array input by the User
		
		int arr[] = new int[size];
		
		System.out.println(" Enter the " + " Elements of the Array : ");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();				// Getting the Elements of the Array input by the User
		}
		
		int max = arr[0];				// Assuming the 1st element of the Array as the largest element
		int min = arr[0];				// Assuming the 1st element of the Array as the smallest element
		
		for ( int i = 0 ; i < size ; i++ ) {
			if ( arr[i] > max )				// Compare the other elements of the Array with the value of max
				max = arr[i];
			else if( arr[i] < min )
				min = arr[i];				// Compare the other elements of the Array with the value of min
		}
		
		System.out.println("\n The Maximum/Largest Element in the Array = " + max);
		System.out.println("\n The Minimum/Smallest Element in the Array = " + min);
	}

}
