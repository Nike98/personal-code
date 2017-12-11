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
 * 4              *         *
 * 
 * 5         *                   *
 * 
 * 6    *                             *
 * 
 * Here, the if condition consists of the code that assigns
 * the value of row and col to i & j respectively.
 * These values are incremented and decremented accordingly
 * to get the desired output of the right to left line.
 * 
 * The else if consists of the code to print the
 * stars where the row and the column are equal to each other.
 * 
 */

public class x_patt {
	public static void main (String args[]) {
		int i = 0, j = 6;
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 7 ; col++ ) {
				if ( row == i && col == j ) {
					System.out.print(" *");
					i += 1;
					j -= 1;
				}
				else if ( row == col )
					System.out.print(" *");
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
