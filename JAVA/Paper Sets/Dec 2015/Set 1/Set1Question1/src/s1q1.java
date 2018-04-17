/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP which will accept 2 Command Line Arguments from 
 * 		the User and prints which one is greater.
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s1q1 {

	public static void main(String[] args) {
		
		int num1 = Integer.parseInt(args[0]);
		int num2 = Integer.parseInt(args[1]);
		
		if ( num1 > num2 )
			System.out.println("\n " + num1 + " is the Greater value");
		
		else
			System.out.println("\n " + num2 + " is the Greater value");
	}

}
