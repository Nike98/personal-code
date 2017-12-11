/*
 *      0    1    2    3    4
 * 
 * 0    *    *    *    *    *
 * 
 * 1    *   
 * 
 * 2    *
 * 
 * 3    *    *    *    *    *
 * 
 * 4    *
 * 
 * 5    *
 * 
 * 6    *    *    *    *    *
 * 
 * Here, in the 1st condition the 0th
 * column is printed with stars.
 * 
 * The 2nd condition prints the 0th, 3rd and the 6th row with stars.
 */

public class e_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0)  ||  ((row == 0 || row == 3 || row == 6) && col > 0) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
