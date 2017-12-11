/*
 *      0    1    2    3    4
 * 
 * 0    *                   *
 * 
 * 1    *                   *
 * 
 * 2    *                   *
 * 
 * 3    *                   *
 * 
 * 4    *                   *
 * 
 * 5    *                   *
 * 
 * 6         *    *    *
 * 
 * Here, in the 1st statement of the if condition the
 * compiler is told to print stars in the 0th and the 4th 
 * column excluding the 6th row.
 * 
 * The 2nd statement prints the stars in the 
 * 6th column excluding the 0th and the 4th column.
 * 
 */
public class u_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( ((col == 0 || col == 4) && row < 6)  ||  (row == 6 && (col > 0 && col < 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
