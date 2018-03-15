/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to input 3 integer numbers and 
 * 		 find the largest and lowest among them.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class largest {

	public static void main(String[] args) {
		Scanner inp = new Scanner (System.in);
		
		int num1, num2, num3;
		
		System.out.print(" Enter the 1st Number : ");
		num1 = inp.nextInt();
		System.out.print(" Enter the 2nd Number : ");
		num2 = inp.nextInt();
		System.out.print(" Enter the 3rd Number : ");
		num3 = inp.nextInt();
		
		if ( num1 != num2 && num2 != num3 && num3 != num1 ) {
			largest_func (num1, num2, num3);
			lowest_func (num1, num2, num3);
		}
		else
			System.out.println("\n All the Inputs are EQUAL.");
	}
	
	public static void largest_func (int a, int b, int c) {
		
			if ( a > b && a > c )
				System.out.println("\n The Largest value = " + a);
			else if ( b > a && b > c )
				System.out.println("\n The Largest value = " + b);
			else
				System.out.println("\n The Largest value = " + c);
	}
	
	public static void lowest_func (int a, int b, int c) {
		
			if ( a < b && a < c )
				System.out.println(" The Lowest value = " + a);
			else if ( b < a && b < c )
				System.out.println(" The Lowest value = " + b);
			else
				System.out.println(" The Lowest value = " + c);
	}

}
