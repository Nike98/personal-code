/*
 *      0    1    2    3    4
 * 
 * 0    *    *    *    *    
 * 
 * 1    *                   *
 * 
 * 2    *                   *
 * 
 * 3    *    *    *    *                 
 * 
 * 4    *           		*        
 * 
 * 5    *                   *
 * 
 * 6    *					*
 * 
 * Here, the 1st statement in the if condition prints the 
 * stars in the 0th column of the pattern.
 * 
 * The 2nd statement prints the line of stars in the 
 * 4th column minding not to print in the 0th and the 3rd row.
 * 
 * The 3rd statement includes the code to print the 
 * stars in the 0th and 3rd row excluding the 
 * 0th and the 4th column of the pattern.
 * 
 */

public class r_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0) || (col == 4 && (row != 0 && row != 3))  ||  ((row == 0 || row == 3) && (col > 0 && col < 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
