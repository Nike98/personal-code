/*
 * Demo pattern : 
 * 
 * 1
 * 2 3
 * 4 5 6
 * 7 8 9 10
 *  
 */

import java.util.Scanner;

public class floyd_tri {
	public static void main (String args[]) {
		int num = 1;
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number of Lines : ");
		int line = inp.nextInt();
		
		for ( int row = 1 ; row <= line ; row++ ) {
			for ( int col = 1 ; col <= row ; col++ ) {
				System.out.print(" " + num);
				num++;
			}
			System.out.println("");
		}
	}
}
