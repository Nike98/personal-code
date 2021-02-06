
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a Java program that can manage NumberFormatException.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class NumFormat {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		try {
			System.out.print("\n Enter a number: ");
			String n = sc.nextLine();
			int num = Integer.parseInt(n);
			
			System.out.println("\n " + num);
		} catch (NumberFormatException e) {
			System.out.println("\n ERROR: NumberFormatException occurred.");
		}
	}

}
