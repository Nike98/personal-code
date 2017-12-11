/*
 *     0   1   2   3   4
 * 
 * 0   *   *   *   *   
 * 
 * 1   *               *
 * 
 * 2   *               *
 * 
 * 3   *   *   *   *    
 * 
 * 4   *               *
 * 
 * 5   *               *
 * 
 * 6   *   *   *   *   
 * 
 * Here, in the 1st condition we tell the compiler to print the 
 * stars in all the rows excluding 0, 3 & 6.
 * 
 * The 2nd condition consists of the code to print the stars
 * in the 0, 3 and 6 row in the 0th and 4th column.
 *  
 */

public class b_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col ++ ) {
				if ( ( (col == 0) || (col == 4 && (row != 0 && row != 3 && row != 6)) )  ||  ( (row == 0 || row == 3 || row == 6)  &&  (col > 0  &&  col <4) ) ) {
					System.out.print(" *");
				}
				else 
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
