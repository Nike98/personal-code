/*
 * ############################################################################
 * ############################################################################
 * 
 * This program here, takes input from the User and 
 * checks whether it is in Upper case or Lower case.
 * 
 * If it is in Upper case, it will be converted to Lower case
 * and if it is in Lower case, it will be converted to Upper case.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class upp_to_low {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		char usr_inp;
		
		System.out.print(" Enter the String : ");
		usr_inp = inp.next().charAt(0);
		
		if ( Character.isLowerCase(usr_inp) ) {
			System.out.println(" " + Character.toUpperCase(usr_inp));
		}
		
		else if ( Character.isUpperCase(usr_inp) ) {
			System.out.println(" " + Character.toLowerCase(usr_inp));
		}
		
		else 
			System.out.println(" WRONG INPUT");
	}

}
