/*
 * ############################################################################
 * ############################################################################
 * 
 * 				This program takes input from the User in Decimal 
 * 					and converts it to the Binary Numerical. 
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class dec_to_bin {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int number;
		System.out.print(" Enter the Decimal Number : ");
		number = inp.nextInt();
		
		long binary = DecimalToBinaryConverter (number);
		
		System.out.println(" The Binary Conversion = " + binary);
	}
	
	public static long DecimalToBinaryConverter ( int num ) {
		long binarynum = 0;
		int remainder, i = 1;
		
		while ( num != 0 ) {
			remainder = num % 2;
			num /= 2;
			binarynum += remainder * i;
			i *= 10;
		}
		return binarynum;
	}

}
