/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP to accept 3 Command Line arguments from 
 * 		the User and print the greatest among them.
 * 
 * ############################################################################
 * ############################################################################
*/

public class s1q1 {

	public static void main(String[] args) {
		
		int num1 = Integer.parseInt(args[0]);
		int num2 = Integer.parseInt(args[1]);
		int num3 = Integer.parseInt(args[2]);
		
		if ((num1 > num2) && (num1 > num3))
			System.out.println("\n " + num1 + " is the Greatest of all.");
	
		else if ((num2 > num1) && (num2 > num3))
			System.out.println("\n " + num2 + " is the Greatest of all.");
		
		else
			System.out.println("\n " + num3 + " is the Greatest of all.");
	}

}
