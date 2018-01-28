/*
 * Demo Pattern : 
 * 
 * 1 2 3 4 5
 * 1 2 3 4
 * 1 2 3
 * 1 2
 * 1
 * 
 */

import java.util.Scanner;

public class reverse_num_patt {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		int line, num = 1;
		
		System.out.print(" Enter the Number of Lines : ");
		line = inp.nextInt();
		System.out.println("");
		
		for ( int row = line ; row > 0 ; row-- ) {
			for ( int col = row ; col > 0 ; col-- ) {
				System.out.print(" " + num);
				num++;
			}
			System.out.println("");
			num = 1;
		}
	}

}
