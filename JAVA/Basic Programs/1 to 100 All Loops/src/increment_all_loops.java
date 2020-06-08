/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP to print 1 to 100 using :
 * 			1. For Loop
 * 			2. While Loop
 * 			3. Do While Loop
 * 
 * ############################################################################
 * ############################################################################
*/

public class increment_all_loops {

	public static void main(String[] args) {
		System.out.println(" -> 1 - 100 using For Loop");
		method_for_loop(0);
		System.out.println("\n -> 1 - 100 using While Loop");
		method_while_loop(1);
		System.out.println("\n -> 1 - 100 using Do While Loop");
		method_do_while(1);
	}
	
	public static int method_for_loop ( int num_for ) {
		for ( num_for = 1 ; num_for <= 100 ; num_for++ ) {
			System.out.println(" " + num_for);
		}
		return num_for;
	}
	
	public static int method_while_loop ( int num_while ) {
		while ( num_while <= 100 ) {
			System.out.println(" " + num_while);
			num_while++;
		}
		return num_while;
	}
	
	public static int method_do_while ( int num_do ) {
		do {
			System.out.println(" " + num_do);
			num_do++;
		} while ( num_do <= 100 );
		return num_do;
	}

}
