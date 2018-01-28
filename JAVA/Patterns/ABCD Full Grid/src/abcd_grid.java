/*
 * Demo Pattern : 
 * 
 * A A A A A
 * B B B B B
 * C C C C C
 * D D D D D
 * E E E E E
 * 
 */

import java.util.Scanner;

public class abcd_grid {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number of Lines : ");
		int line = inp.nextInt();
		System.out.println();
		
		char c = 'A';
		
		for ( int row = 0 ; row <= line ; row++ ) {
			for ( int col = 0 ; col <= line ; col++ ) {
				System.out.print(" " + c);
			}
			System.out.println();
			c++;
		}
	}

}
