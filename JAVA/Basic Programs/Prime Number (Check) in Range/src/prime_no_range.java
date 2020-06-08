/*
 * ############################################################################
 * ############################################################################
 * 
 * 				This program here is to check the all prime 
 * 					numbers in a given range by the user.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class prime_no_range {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int start_pt, end_pt;
		
		System.out.print(" Enter the Starting point : ");
		start_pt = inp.nextInt();
		System.out.print(" Enter the Ending point : ");
		end_pt = inp.nextInt();
		
		System.out.printf("\n The Prime Numbers between %d and %d are : \n\n", start_pt, end_pt);
		
		while ( start_pt < end_pt ) {
			boolean flag = false;
			
			for ( int i = 2 ; i <= start_pt / 2 ; i++ ) {
				// Condition for non prime
				if ( start_pt % i == 0 ) {
					flag = true;
					break;
				}
			}
			
			if ( !flag )
				System.out.println(" " + start_pt);
			
			start_pt++;
		}
	}

}
