/*
 * ############################################################################
 * ############################################################################
 * 
 * 				This program here as the code to identify
 * 			   	Vowels, Consonants, Digits and Spaces in a
 * 			  String input by the User and Display the count.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class main_identifier {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);						// Creating  Scanner object to take user input
		
		String usr_input;											// Creating an object of the string class to store the input
		
		int vowels = 0, consonants = 0, digits = 0, spaces = 0, special_char = 0;
		/* Initializing all these values as 0 so that the incrementation
		 * should compulsorily start from 0 and not any garbage or
		 * random value.
		 */
		
		System.out.print(" Enter the String : ");
		usr_input = inp.nextLine();
		
		usr_input = usr_input.toLowerCase();						// Converting the input to lower case for lower error chances
		
		for ( int i = 0 ; i < usr_input.length() ; i++ ) {
			char ch = usr_input.charAt(i);							// Picking up each character from the string to be checked
			
			if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') 
				++vowels;
	            
	        else if((ch >= 'a'&& ch <= 'z')) 
	        	++consonants;
	            
	        else if( ch >= '0' && ch <= '9')
	        	++digits;
	            
	        else if (ch ==' ')
	          	++spaces;
	        
	        else
	        	++special_char;
		}
		
		System.out.println("\n The counts are as follows :");
		System.out.println(" Vowels = " + vowels);
        System.out.println(" Consonants =  " + consonants);
        System.out.println(" Digits =  " + digits);
        System.out.println(" White spaces =  " + spaces);
        System.out.println(" Special Characters = " + special_char);
	}

}
