/*
 *      0    1    2    3    4    5    6
 * 
 * 0    *                             *
 * 
 * 1    *                             *
 * 
 * 2    *                             *
 * 
 * 3    *              *              *
 * 
 * 4    *         *         *         *
 * 
 * 5    *    *                   *    *
 * 
 * 6    *                             *
 * 
 * Here, the first if condition consists of two statements.
 * 
 * The 1st statement consists of the code which prints the
 * stars on the 0th and 6th column of the pattern.
 * 
 * The 2nd statement has two major statements which print the 
 * stars where the row and the column are same.
 * 
 * The next is the else if condition which specifies the 
 * value of the row and the column by the values of i & j,
 * these values are incremented and decremented to print the stars.
 * 
 */

public class w_patt {
	public static void main (String args[]) {
		int i = 3, j = 3;
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 7 ; col++ ) {
				if ( (col == 0 || col == 6)  ||  (row == col && (col > 3 && col <6)) ) {
					System.out.print(" *");
				}
				else if ( row == i && col == j ) {
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
