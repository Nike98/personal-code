/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This program is the implementation of using multiple
 * 					  methods to implement an Array.
 * 
 * 				This program here, has 2 methods :
 * 					1. To input the array
 * 					2. To Manipulate it.
 * 
 * 				The Array in input and the function 
 * 			   is called to manipulate it which adds 
 * 			 +5 to all the element values in the Array.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class main_array_body {

	public static void main(String[] args) {
		int arr[] = new int[5];									// Array identifier declaration
		Scanner scan = new Scanner(System.in);
		
		System.out.println(" Enter 5 Elements into the Array : ");
		
		for ( int count = 0 ; count < 5 ; count++ ) {
			arr[count] = scan.nextInt();						// Taking the input from the user
		}
		
		manipulate_array (arr);									// Function to manipulate the array being called
		
		System.out.println("\n The Manipulated Array is : ");
		
		for ( int i : arr ) {
			System.out.println(" " + i);						// Enhanced for displaying the array 
		}
	}
	
	public static void manipulate_array ( int x[] ) {
		for ( int manip = 0 ; manip < x.length ; manip++ ) {
			x[manip] += 5;										// Adding +5 to all the Array elements
		}
	}

}
