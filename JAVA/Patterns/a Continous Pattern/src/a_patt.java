/*
 * Demo Pattern : 
 * 
 * a
 * a a
 * a a a 
 * a a a a
 * a a a a a
 * 
 */

import java.util.Scanner;

public class a_patt {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int line;
		
		System.out.print(" Enter the Number of Lines : ");
		line = inp.nextInt();
		System.out.println("");
		
		for ( int row = 0 ; row <= line ; row++ ) {
			for ( int col = 0 ; col <= row ; col++ ) {
				System.out.print(" a");
			}
			System.out.println();
		}
	}

}
