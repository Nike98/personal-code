/*
 *      0    1    2    3    4
 * 
 * 0    *					*
 * 
 * 1    *   				*
 * 
 * 2    *					*
 * 
 * 3    *    *    *    *    *
 * 
 * 4    *					*
 * 
 * 5    *					*
 * 
 * 6    *					*
 * 
 * Here, the 1st condition prints the stars in the 
 * 0th and the 4th column of the pattern.
 * 
 * The 2nd condition prints the stars in the 3rd row
 * between the 1st and the 4th column.
 * 
 */

public class h_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0 || col == 4)  || (row == 3 && (col > 0 && col <4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
