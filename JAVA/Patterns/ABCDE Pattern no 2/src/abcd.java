/*
 * Demo Pattern : 
 * 
 * A
 * B B
 * C C C
 * D D D D
 * E E E E E
 * 
 */

import java.util.Scanner;

public class abcd {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number of Lines : ");
		int line = inp.nextInt();
		System.out.println();
		
		char c = 'A';
		
		for ( int row = 0 ; row <= line ; row++ ) {
			for ( int col = 0 ; col <= row ; col++ ) {
				System.out.print(" " + c);
			}
			System.out.println();
			c++;
		}
	}

}
