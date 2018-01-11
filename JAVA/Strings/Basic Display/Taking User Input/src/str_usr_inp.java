/*
 * ############################################################################
 * ############################################################################
 * 
 * 	        This program is a basic representation of how to 
 *             input a string from the user, make a String object,
 * 		store the string in it and display it to the user.
 * 
 * 		To scan and store the input taken from the user we
 * 		         will import a Scanner namespace.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class str_usr_inp {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);					// Making a Scanner object (inp) to be used
		
		String input_string;
		
		System.out.print(" Enter the String : ");							
		// Saving the string input by the user in a input_string variable of the String object class
		input_string = inp.nextLine();
		
		// Displaying the string input by the user
		System.out.printf("\n The String = %s", input_string);	
		
		/*
		 * 			Here, the printf or the print formatter funtion of the 
		 * 			System.out library is used to format the string in the way
		 * 			it has to be displayed and the '%s' means that the 
		 * 			type of output is a string.
		 */
	}

}
