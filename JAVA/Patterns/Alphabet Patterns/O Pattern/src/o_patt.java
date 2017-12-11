/*
 *      0    1    2    3    4
 * 
 * 0         *    *    *    
 * 
 * 1    *                   *
 * 
 * 2    *                   *
 * 
 * 3    *                   *
 * 
 * 4    *                   *
 * 
 * 5    *                   *
 * 
 * 6         *    *    *
 * 
 * Here, the 1st statement in the if condition states that 
 * the stars should be printed in the 0th and 4th column
 * of the pattern minding that there are no stars to be
 * printed in the 0th and 6th row.
 * 
 * The 2nd statement states that the stars should be
 * printed in the 0th and 6th row minding that the 
 * 0th and 4th column be left untouched.
 * 
 */

public class o_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( ((col == 0 || col == 4) && (row > 0 && row < 6))  ||  ((row == 0 || row == 6) && (col > 0 && col < 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
