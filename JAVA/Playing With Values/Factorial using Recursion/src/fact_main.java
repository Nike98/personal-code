/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program here takes the input from the user
 * 		and prints the Factorial of that number
 * 		using Recursion.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class fact_main {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter a Positive Integer : ");
		int num = inp.nextInt();
		
		long ans = Factorial(num);
		
		if ( ans == 1 )
			System.out.println("\n The Factorial = 1");
		else
			System.out.println("\n The Factorial = " + ans);
	}
	
	public static long Factorial (long f) {
		if ( f <= 1 )
			return 1;
		else
			return ( f * Factorial(f - 1) );
	}

}
