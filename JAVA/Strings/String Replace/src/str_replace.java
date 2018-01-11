/*
 * ############################################################################
 * ############################################################################
 * 
 * 		    This program here is to demonstrate the use 
 *     		          of the string replace() function.
 * 
 * 	      The replace() function replaces the specifies characters 
 * 	         in the string with the other specified characters. 
 * 
 * ############################################################################
 * ############################################################################
*/

public class str_replace {

	public static void main(String[] args) {
		String str = "This is the boy.";
		
		String replaced_string = str.replaceAll(" is", "was");
		
		System.out.println(" " + replaced_string);
	}

}
