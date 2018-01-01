/*
 * ############################################################################
 * ############################################################################
 * 
 * 						This is a simple example of 
 * 						 Variable Length Arguments.
 * 
 * 				Here, it is shown that when you want to pass
 * 					multiple arguments to a function and
 * 				don't know how many, you can directly use the 
 * 				 data-type and the variable name with (...). 
 * 
 * ############################################################################
 * ############################################################################
*/

public class var_len_args {
	public static void main (String args[]) {
		System.out.println(" The Average = " + average(29,62,85,19,52,5));
	}
	
	public static int average ( int...num ) {
		int sum = 0;
		
		for ( int x : num ) {
			sum += x;
		}
		
		return sum / num.length;
	}
}





/* Write Comments..........................*/