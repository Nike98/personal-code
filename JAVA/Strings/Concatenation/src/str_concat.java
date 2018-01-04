/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program is to demonstrate the idea of 
 * 		          Concatenating a String.
 * 
 *                 Concatenating a String means joining
 * 		      one string to another string.
 * 
 *       There are 2 ways of concatenating a string :
 *             1. using the '.concat();' with the string or string object
 * 	       2. using the concatenating symbol '+'.
 * 
 * ############################################################################
 * ############################################################################
*/

public class str_concat {

	public static void main(String[] args) {
		String str1 = "Hi";
		String str2 = " How are you";
		
		// The different ways to concatenate the string are shown below
		
		System.out.printf(" %s\n",str1.concat(str2));			// Using the '.concat();' function
		System.out.println(" " + str1 + "," + str2);			// Using the concatenation '+' symbol
		System.out.println(" " + str1.concat(str2));			// Using both (for a surprise)
	}

}
