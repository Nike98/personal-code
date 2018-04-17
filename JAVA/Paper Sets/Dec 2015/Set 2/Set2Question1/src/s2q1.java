/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to accept a number as Command Line Argument 
 * 		and print if it's ODD or EVEN.
 * 
 * ######################################################################################
 * ######################################################################################
*/
public class s2q1 {

	public static void main(String[] args) {
		
		int num = Integer.parseInt(args[0]);
		
		if ( num % 2 == 0 )
			System.out.println("\n It is an EVEN Number");
		else
			System.out.println("\n It is an ODD Number");
	}

}
