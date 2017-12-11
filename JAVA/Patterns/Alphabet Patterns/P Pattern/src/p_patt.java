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
 * 4    *                   
 * 
 * 5    *                   
 * 
 * 6    *
 * 
 * Here, the 1st statement in the if condition states that the
 * stars should be printed in the 0th column.
 * 
 * The 2nd statement states that the 4th column should have 
 * stars where the 1st and the 2nd row exists.
 * 
 * The 3rd statement includes the code to print the stars in the  
 * 0th and 3rd row excluding the 0th and 4th column.
 * 
 */

public class p_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 0) || (col == 4 && (row == 1 || row == 2))  ||  ((row == 0 || row == 3) && (col > 0 && col < 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
