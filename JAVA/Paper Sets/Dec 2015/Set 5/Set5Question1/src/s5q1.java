/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to accept a String from the User and print
 * 		the Length of the String.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class s5q1 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the String : ");
		String str = inp.nextLine();
		
		System.out.println("\n The Length of the Entered String is = " + StringLength(str));
	}
	
	public static int StringLength (String str) {
		
		int len = 0;
		str += '\0';		// Adds the null character('\0) at the end of the String str 
		
		for ( int i = 0 ; str.charAt(i) != '\0' ; i++ )		// Loop will rotate until it incurs a null character within or after the string
			len++;
		
		return len;
	}

}
