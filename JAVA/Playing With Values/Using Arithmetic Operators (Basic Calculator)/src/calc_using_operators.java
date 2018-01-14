/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to input 2 integer numbers and one operator
 * 		  and perform "Arithmetic Operation" like (+,-,*,/,%)
 * 					according to User input.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class calc_using_operators {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		char operator_inp;
		int num1, num2, ans = 0;
		
		System.out.print(" Enter the 1st Number : ");
		num1 = inp.nextInt();
		System.out.print(" Enter the 2nd Number : ");
		num2 = inp.nextInt();
		
		System.out.print(" Enter the Arithmetic Operator to proceed : ");
		operator_inp = inp.next().charAt(0);
		
		if ( operator_inp == '+' ) 
			ans = num1 + num2;
		else if( operator_inp == '-' )
			ans = num1 - num2;
		else if ( operator_inp == '*' )
			ans = num1 * num2;
		else if ( operator_inp == '/' )
			ans = num1 / num2;
		else if ( operator_inp == '%' )
			ans = num1 % num2;
		
		System.out.println("\n The Answer = " + ans);
	}

}
