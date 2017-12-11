/*
 *      0    1    2    3    4
 * 
 * 0    *
 * 
 * 1    *   
 * 
 * 2    *
 * 
 * 3    *
 * 
 * 4    *
 * 
 * 5    *
 * 
 * 6    *    *    *    *    *
 * 
 * Here, the 1st statement on the if condition states that
 * the stars should be printed in the 0th column of the pattern.
 * 
 * The 2nd statement prints the stars in the 6th row 
 * minding that the column is greater than 0.
 * 
 */

public class l_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0)  ||  (row == 6 && col > 0) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
