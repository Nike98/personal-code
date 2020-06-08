/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This program here, check and displays the Armstrong 
 * 			 number in a particular range entered by the User.
 * 
 * 			The check_Armstrong method checks whether the number
 * 				  incurred is an Armstrong Number or not.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class armstrong_range {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int start_pt, end_pt;
		
		System.out.print(" Enter the Starting point : ");
		start_pt = inp.nextInt();
		System.out.print(" Enter the Ending point : ");
		end_pt = inp.nextInt();
		
		System.out.printf("\n The Armstrong Numbers between %d and %d are : \n\n", start_pt, end_pt);
		
		for ( int number = start_pt + 1 ; number < end_pt ; number++ ) {
			if ( check_Armstrong (number) )
				System.out.println(" " + number);
		}
	}
	
	// A dedicated method to find if the number is an Armstrong numbers 
	
	public static boolean check_Armstrong ( int num ) {
		int digits = 0, result = 0;
		int og_num = num;
		
		// Calculating the number of digits present
		while ( og_num != 0 ) {
			og_num /= 10;
			++digits;
		}
		
		// Reinitializing the value of og_num as it was lost while calculating number of digits
		og_num = num;
		
		while ( og_num != 0 ) {
			int remainder = og_num % 10;
			result += Math.pow(remainder, digits);
			og_num /= 10;
		}
		
		// Checking if the result is the same as the original number to be the Armstrong Number
		if ( result == num )
			return true;
		
		return false;
	}

}
