/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to accept Starting Number and Ending Number from 
 * 		the User. If Starting Number is greater than the 
 * 		Ending Number then interchange the numbers and 
 * 		print the Even numbers between them.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class s5q2 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		// Getting the Input for the Starting Number from the User
		System.out.print(" Enter the Starting Bound : ");
		int start = inp.nextInt();
		
		// Getting the Input for the Ending Number from the User
		System.out.print("\n Enter the Ending Bound : ");
		int end = inp.nextInt();
		
		/* 
		 * Checking if the Starting Number is Greater than 
		 * the Ending Number.
		 * 
		 * If it is so then the values of the Starting Number 
		 * and the Ending Number are interchanged.
		 * 
		 * Otherwise the program execution works normally.
		 */
		if ( start > end ) {
			
			int temp = start;
			start = end;
			end = temp;
		}
		
		else {
			
			// Printing the Even Numbers between the given range
			System.out.println("\n The Even Numbers between the given range are : \n");
			for ( int i = start ; i <= end ; i++ ) {
				
				// Formula to check for even numbers
				if ( i % 2 == 0 ) {
					
					System.out.println(" " + i);
				}
			}
		}
	}

}
