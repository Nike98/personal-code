/*
 *      0    1    2    3    4
 * 
 * 0    *    *    *    *    *
 * 
 * 1    *   
 * 
 * 2    *
 * 
 * 3    *              *    *
 * 
 * 4    *					*
 * 
 * 5    *					*
 * 
 * 6    *    *    *    *    *
 * 
 * Here, we have 4 types of conditions to complete the G Pattern.
 * 
 * The 1st condition prints the stars in the 0th column.
 * 
 * The 2nd condition prints stars in the 4th column.
 * Here, excluding the 1st and 2nd row.
 * 
 * The 3rd condition prints stars in the 0th and 6th row
 * till the 4th column.
 * 
 * The 4th condition prints the single star in 
 * the 3rd row and 3rd column to make a G.
 *  
 */

public class g_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0)  ||  (col == 4 && (row != 1 && row != 2))  ||  ((row == 0 || row == 6) && (col > 0 && col < 4))  ||  (row == 3 && col == 3) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
