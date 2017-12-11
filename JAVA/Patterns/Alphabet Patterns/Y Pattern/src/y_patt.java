/*
 *      0    1    2    3    4    5    6
 * 
 * 0    *                             *
 * 
 * 1         *                   *
 * 
 * 2              *         *
 * 
 * 3                   *
 * 
 * 4                   *
 * 
 * 5                   *
 * 
 * 6                   *
 * 
 * Here, the if condition consists of two statements,
 * the 1st statement states that the stars should be printed 
 * where the 3rd column exists but the printing shuold start 
 * from the 3rd row.
 * 
 * The 2nd statement states that the stars should be
 * printed where row and column are equal but till the
 * column is 2.
 * 
 * The else if condition states that the row and the column 
 * should be equal to the initialized variables and the
 * incrementation should be till the row is less than 3 and
 * the column is greater than 2.
 * 
 */

public class y_patt {
	public static void main (String args[]) {
		int i = 0, j = 6;
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 7 ; col++ ) {
				if ( (col == 3 && (row > 2))  ||  ((row == col) && col < 3) ) {
					System.out.print(" *");
					
				}
				else if ( (row == i && col == j) && (row < 3 && col > 2) ) {
					System.out.print(" *");
					i += 1;
					j -= 1;
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
