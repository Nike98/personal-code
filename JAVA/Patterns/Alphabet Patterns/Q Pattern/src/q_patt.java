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
 * 5    *    *              *
 * 
 * 6         *    *    *
 * 
 * 7				   *
 * 
 * Here, in the if condition, the first 2 main conditions
 * are used to print the O shape.
 * 
 * The code following the first 2 statements prints the stars
 * in the particular specified place.
 * 
 */

public class q_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 8 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( ((col == 0 || col == 4) && (row > 0 && row < 6))  ||  ((row == 0 || row == 6) && (col > 0 && col < 4))  ||  (row == 5 && col ==1)  ||  (row == 7 && col == 3) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
