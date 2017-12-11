/*
 *     0   1   2   3   4
 * 
 * 0       *   *   *  
 * 
 * 1   *               *
 * 
 * 2   *               * 
 * 
 * 3   *   *   *   *   *
 * 
 * 4   *               *
 * 
 * 5   *               * 
 * 
 * 6   *               *
 * 
 * Here. 1st we print the left hand side and right hand side
 * of the columns (from row - 1 to 6 & col - 4 ).
 * 
 * Then, in the 2nd condition we tell the compiler to 
 * fill stars in the 0th and 3rd row.
 *  
 */

public class a_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( ((col == 0 || col == 4)  &&  row != 0)  ||  ((row == 0 || row == 3)  &&  (col > 0 && col < 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
