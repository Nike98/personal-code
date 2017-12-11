/*
 *     0    1    2    3    4
 * 
 * 0        *    *    *    *
 * 
 * 1   *    
 * 
 * 2   * 
 * 
 * 3   *
 * 
 * 4   *
 * 
 * 5   *
 * 
 * 6        *    *    *    *
 * 
 * Here, the 1st condition fills the column 0 
 * with stars, minding that row 0 and 6 are excluded.
 * 
 * The 2nd condition prints the row 0 and 6,
 * stating that the col > 0 which excludes the 0th column
 * to be printed.
 *  
 */

public class c_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0  &&  (row != 0 && row != 6))  ||  ((row == 0  || row == 6) && col > 0) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
