
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a java Program to catch Arithmetic exception.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class CatchArithmeticEx {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		try
		{
			System.out.print("\n Enter the first number: ");
			int num1=sc.nextInt();
			
			System.out.print("\n Enter the second number: ");
			int num2=sc.nextInt();
			
			int output=num1/num2;
			
			System.out.println("\n Result: " + output);
		}
		catch(ArithmeticException e)
		{
			System.out.println("\n ERROR: Attempted Divide by Zero.");
			System.out.println(" Number shouldn't be divided by zero.");
		}

	}

}
