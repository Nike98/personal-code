/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP in Java to print all Even & Odd
 * 		Numbers between 1 - 100 using : 
 * 			1. For Loop
 * 			2. While Loop
 * 			3. Do While Loop
 * 
 * ############################################################################
 * ############################################################################
*/

public class odd_even_main {

	public static void main(String[] args) {
		derive_odd_even deriveObject = new derive_odd_even();
		
		System.out.println(" All the Odd and Even Numbers between 1 - 100 Using For Loop\n");
		System.out.println("\tODD\tEVEN\n");
		deriveObject.using_for_loop();
		
		System.out.println(" All the Odd and Even Numbers between 1 - 100 Using While Loop\n");
		System.out.println("\tODD\tEVEN\n");
		deriveObject.using_while_loop();
		
		System.out.println(" All the Odd and Even Numbers between 1 - 100 Using Do While Loop\n");
		System.out.println("\tODD\tEVEN\n");
		deriveObject.using_do_while();
	}

}
