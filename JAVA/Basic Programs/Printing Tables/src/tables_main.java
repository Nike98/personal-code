/*
 * ############################################################################
 * ############################################################################
 * 
 *			 WAP to input Positive Integer number 
 * 				and Print it's Table. 
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class tables_main {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int number, prod;
		
		System.out.print(" Enter a Positive Integer : ");
		number = inp.nextInt();
		System.out.println();
		
		if ( number > 0 ) {
			for ( int i = 1 ; i <= 10 ; i++ ) {
				prod = number * i;
				System.out.printf(" %d x %d = %d\n", number, i, prod);
			}
		}
		else
			System.out.println(" ENTER A POSITIVE INTEGER");
	}

}
