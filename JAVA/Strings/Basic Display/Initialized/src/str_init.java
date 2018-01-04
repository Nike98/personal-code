/*
 * ############################################################################
 * ############################################################################
 * 
 * 	     This program here is an implementation to use the String 
 *           object available in JAVA in 2 ways:
 *                 1. To initialize it directly.
 * 		   2. To create a new String object. 
 * 
 * ############################################################################
 * ############################################################################
*/

public class str_init {

	public static void main(String[] args) {
		// Basic initialization of a String object using the String keyword
		String str1 = "This is initialized Directly";
		
		// Initialization of the String using a new String object also by using char data type
		char[] char_string_init = {'h', 'e', 'l', 'l', 'o'};
		String hello_char_string = new String (char_string_init);		// new String object created using char array
		
		// Printing both the outputs
		System.out.println(" " + str1);
		System.out.println("\n " + hello_char_string);
	}

}
