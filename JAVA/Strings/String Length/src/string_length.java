/*
 * ############################################################################
 * ############################################################################
 * 
 * 	     This program here is to demonstrate the use of the
 * 			String.Length function.
 * 
 * 	   This function is used to derive the length of a String.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class string_length {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		String str1;
		
		System.out.print(" Enter the String : ");
		str1 = inp.nextLine();
		
		System.out.println(" The Length of the String input is = " + str1.length());
	}

}
