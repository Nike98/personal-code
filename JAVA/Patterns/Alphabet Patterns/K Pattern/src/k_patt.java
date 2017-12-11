/*
 *      0    1    2    3   4
 * 
 * 0    *                  *
 * 
 * 1    *              *
 * 
 * 2    *         *
 * 
 * 3    *    *
 * 
 * 4    *         *
 * 
 * 5    *              *
 * 
 * 6    *                   *
 * 
 * Here, in the 1st if condition , the 1st statement states that
 * the stars should be printed in the 0th column of the pattern.
 * 
 * The 2nd statement consists of the code to print the stars
 * row-4 to row-6.
 * 
 * The else if conditional statement consists of the code
 * to print the stars from row-3 to column-4.
 * 
 */

public class k_patt {
	public static void main (String args[]) {
		int i = 0, j = 4;
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0)  || (row == col + 2 && col > 1) ) {
					System.out.print(" *");
				}
				else if ( (row == i && col == j)  &&  col > 0 ) {
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
