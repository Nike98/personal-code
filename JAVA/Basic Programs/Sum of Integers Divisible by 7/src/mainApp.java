/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP to find the sum of all the integers(in a given range)
 * 		which are divisible by 7.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class mainApp {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int sum = 0;
		int range_start, range_end;
		
		System.out.print("Enter the range start: ");
		range_start = sc.nextInt();
		
		System.out.print("Enter the range end: ");
		range_end = sc.nextInt();
		
		for (int i = range_start; i <= range_end; i++) {
			if (i % 7 == 0)
				sum += i;
		}
		
		System.out.println("\n\n Sum of all the Integers between the given range and Divisible by 7 is : " + sum);
	}

}
