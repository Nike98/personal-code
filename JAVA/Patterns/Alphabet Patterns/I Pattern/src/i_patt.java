/*
 *      0    1    2    3    4
 * 
 * 0    *    *    *    *    *
 * 
 * 1              *
 * 
 * 2              *
 * 
 * 3              *
 * 
 * 4              *
 * 
 * 5              *
 * 
 * 6    *    *    *    *    * 
 * 
 * Here, the 1st condition prints the stars in the 2nd column.
 * 
 * The 2nd condition prints the stars in the 
 * 0th and 6th row, excluding the place
 * where the column is 2.
 *   
 */

public class i_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 2)  || ((row == 0 || row == 6) && col != 2) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
