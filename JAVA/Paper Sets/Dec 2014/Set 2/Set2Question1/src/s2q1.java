/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP to accept a year on the Command Line and
 * 		check whether it is a Leap Year or not.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class s2q1 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter a Year : ");
		int year = inp.nextInt();
		
		try {
			
			if ( year % 4 == 0 )
				System.out.println("\n It is a Leap Year.");
			else
				System.out.println("\n It is a Not Leap Year.");
		}catch ( Exception e ) {
			e.printStackTrace();
		}
	}

}
