/*
 * Demo Pattern :
 * 
 * A
 * A B
 * A B C
 * A B C D
 * A B C D E
 * 
 */

import java.util.Scanner;

public class abcde_basic_tri {
	public static void main (String args[]) {
		char c = 'A';
		
		Scanner inp = new Scanner(System.in);
	
		System.out.print(" Enter the Number of Lines : ");
		int line = inp.nextInt();
		
		for ( int row = 1 ; row <= line ; row++ ) {
			c = 'A';
			for ( int col = 1 ; col <= row ; col++ ) {
				System.out.print(" " + c);
				c++;
			}
			System.out.println("");
		}
	}
}
