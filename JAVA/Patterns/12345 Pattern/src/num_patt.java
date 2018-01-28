/*
 * Demo Pattern : 
 * 
 * 1
 * 1 2
 * 1 2 3
 * 1 2 3 4 5
 * 
 */

import java.util.Scanner;

public class num_patt {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int line, num = 1;
		
		System.out.print(" Enter the Number of Lines : ");
		line = inp.nextInt();
		System.out.println("");
		
		for ( int row = 0 ; row < line ; row++ ) {
			for ( int col = 0 ; col <= row ; col++ ) {
				System.out.print(" " + num);
				num++;
			}
			System.out.println("");
			num = 1;
		}
	}

}
