/*
 *      0    1    2    3    4    5
 * 
 * 0    *    *    *    *    *    *
 * 
 * 1                        *
 * 
 * 2                   *
 * 
 * 3              *
 * 
 * 4          *
 * 
 * 5    *     *    *    *    *    *
 * 
 * Here, the if condition has the statement to print the
 * stars in the 0th and the 6th row of the pattern.
 * 
 * The else if condition has the row and the column set
 * according to the initialized variables to print the 
 * diagonal part of the letter Z.
 * 
 */

public class z_patt {
	public static void main (String args[]) {
		int i = 1, j = 4;
		
		System.out.println("");
		
		for ( int row = 0 ; row < 6 ; row++ ) {
			for ( int col = 0 ; col < 6 ; col++ ) {
				if ( row == 0 || row == 5 ) {
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
