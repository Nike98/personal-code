/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP with a function in which a 4 digit number is input.
 * 		The function returns the number wit the digits reversed 
 * 		(if the 4 digit number is 1234 then the output should be 4321).
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class s1q2 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter a 4 Digit Number: ");
		int num = inp.nextInt();
		
		/*
		 * To derive the Length of the num variable because
		 * in JAVA String functions like toString() and
		 * length() are not allowed on the primitive data 
		 * types like (int num) here. 
		 */
		int length = (int)(Math.log10(num)+1);		
		
		if (length == 4) {
			
			int rev_ans = Rev_num(num);
			
			System.out.println("\n The Reversed Number = " + rev_ans);
		}
		else {
			
			System.out.println("\n Please Enter a 4 Digit Number Only.");
		}
		
	}
	
	public static int Rev_num( int num ) {
		
		int og_num, rem, rev = 0;
		
		og_num = num;
		
		while ( og_num != 0 ) {
				
			rem = og_num % 10;
			rev = (rev * 10) + rem;
			og_num /= 10;
			
		}
		
		return rev;
	}

}
