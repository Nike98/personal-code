/*
 * ############################################################################
 * ############################################################################
 * 
 * 					This program here fetches the the ASCII 
 * 						  value of the value entered. 
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class ascii_val_finder {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		char ch;
		
		System.out.print(" Enter a single Character : ");
		ch = inp.next().charAt(0);
		
		// Basic method of finding the ASCII value 
		int ascii_val = ch;
		
		// Another method of finding the ASCII value 
		int castAscii = (int) ch;
		
		System.out.println("\n The ASCII value = " + ascii_val);
		System.out.println(" The ASCII value = " + castAscii);
	}

}
