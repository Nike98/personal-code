/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP in Java to Input alphabet & Check whether the 
 * 			  alphabet is Upper case Character or Lower case 
 * 				 Character or Digits or Special Symbol.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class identifier_func {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);						// Creating  Scanner object to take user input
		
		String usr_input;											// Creating an object of the string class to store the input
		
		int uCase = 0, lCase = 0, digits = 0, spaces = 0, special_char = 0;
		/* Initializing all these values as 0 so that the incrementation
		 * should compulsorily start from 0 and not any garbage or
		 * random value.
		 */
		
		System.out.print(" Enter the String : ");
		usr_input = inp.nextLine();						
		
		for ( int i = 0 ; i < usr_input.length() ; i++ ) {
			char ch = usr_input.charAt(i);							// Picking up each character from the string to be checked
			
			if((ch >= 'A' && ch <= 'Z')) 
				++uCase;
	            
	        else if((ch >= 'a'&& ch <= 'z')) 
	        	++lCase;
	            
	        else if( ch >= '0' && ch <= '9')
	        	++digits;
	            
	        else if (ch ==' ')
	          	++spaces;
	        
	        else
	        	++special_char;
		}
		
		System.out.println("\n The counts are as follows :");
		System.out.println(" Upper Case Letters = " + uCase);
        System.out.println(" Lower Case Letters =  " + lCase);
        System.out.println(" Digits =  " + digits);
        System.out.println(" White spaces =  " + spaces);
        System.out.println(" Special Characters = " + special_char);
	}

}