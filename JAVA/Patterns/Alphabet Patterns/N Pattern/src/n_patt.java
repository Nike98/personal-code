/*
 *     0  1  2  3  4  5
 *    
 * 0   *              *
 * 
 * 1   *  *           *
 * 
 * 2   *     *        *
 * 
 * 3   *        *     *
 * 
 * 4   *           *  *
 * 
 * 5   *              *
 * 
 * Here, in this program the the 1st column of stars from 0 to 5 
 * is printed using the 'row' for loop.
 * 
 * The rest of the work is given to the 'col' for loop.
 * 
 * The 'col' for loop has a 'if condition' which checks 
 * for the relevant col and row mapping.
 * 
 */

public class n_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 1 ; row <= 5 ; row++ ) {
			System.out.print(" *");
			for ( int col = 1 ; col <= 5 ; col++ ) {
				if  ((col == 0)  ||  (col == 5)  ||  ( row == col  &&  (col > 1  &&  col < 5) )) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
