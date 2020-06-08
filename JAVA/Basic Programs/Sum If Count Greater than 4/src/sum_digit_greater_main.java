/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP to input digits and count the number of digits,
 * 	    if the count is greater than 4 then find the Sum of 
 * 					the digits entered.
 * 
 * 		Otherwise display an Error Message
 * 		"Can't perform Sum of the digits".
 * 
 * 				Do this using :
 * 					1. For Loop 
 * 					2. While Loop
 * 					3. Do While Loop
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class sum_digit_greater_main {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);								// Initializing Scanner object to be used
		
		int main_digit, digit_for, digit_while, digit_do, sum = 0;
		
		System.out.print(" Enter the Digits : ");							// Taking the input in main_digit variable
		main_digit = inp.nextInt();
		
		digit_for = count_for_loop( main_digit );
		digit_while = count_while_loop(main_digit);							// Providing variables with digit count from all the loops
		digit_do = count_do_while(main_digit);
		
		if ( digit_for >= 4 || digit_while >= 4 || digit_do >= 4 ) {
			while ( main_digit != 0 ) {
				sum += main_digit % 10;										// Performing the sum of digit logic if the count > or = 4
				main_digit /= 10;
			}
			System.out.println("\n The Sum of the Digits = " + sum);		// Printing the output of the Sum of the Digits
		}
		else
			System.out.println("\n Can't perform Sum of the Digits.");		// To print message if digit count < 4
	}
	
	public static int count_for_loop ( int num_for ) {
		int count = 0;
		
		for ( ; num_for != 0 ; num_for /= 10, count++ ) {
		}
		return count;
	}
	
	public static int count_while_loop ( int num_while ) {
		int count = 0;
		
		while ( num_while != 0 ) {
			num_while /= 10;
			count++;
		}
		return count;
	}
	
	public static int count_do_while ( int num_do ) {
		int count = 0;
		
		do {
			num_do /= 10;
			count++;
		}while( num_do != 0 );
		return count;
	}

}
