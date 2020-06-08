/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to input digits in JAVA and count the Number
 * 			of Digits using :
 * 				1. For Loop
 * 				2. While Loop
 * 				3. Do While Loop
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class digit_count_all_loops {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		int digits;
		
		System.out.print(" Enter the Digits : ");
		digits = inp.nextInt();
		
		System.out.println("\n The Number of Digits entered using For Loop = " + count_for_loop(digits));
		System.out.println(" The Number of Digits entered using While Loop = " + count_while_loop(digits));
		System.out.println(" The Number of Digits entered using Do While Loop = " + count_do_while(digits));
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
