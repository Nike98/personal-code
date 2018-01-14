/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to print A to Z in Upper case using :
 * 				1. For Loop 
 * 				2. While Loop
 * 				3. Do While Loop
 * 
 * ############################################################################
 * ############################################################################
*/

public class a_z_main {

	public static void main(String[] args) {
		System.out.println("\t A ot Z using For Loop\n");
		using_for_loop();
		System.out.println("\t A ot Z using While Loop\n");
		using_while_loop();
		System.out.println("\t A ot Z using Do While Loop\n");
		using_do_while();
	}
	
	public static void using_for_loop () {
		//char c = 'A';
		
		for ( char c = 'A' ; c <= 'Z' ; c++ ) {
			System.out.println(" " + c);
		}
	}
	
	public static void using_while_loop () {
		char c = 'A';
		
		while ( c <= 'Z' ) {
			System.out.println(" " + c);
			c++;
		}
	}
	
	public static void using_do_while () {
		char c = 'A';
		
		do {
			System.out.println(" " + c);
			c++;
		}while ( c <= 'Z' );
	}

}
