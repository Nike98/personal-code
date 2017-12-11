/*
 *   0 1 2 3 4 5 6 
 *   
 * 0 *           *
 * 
 * 1   *       *
 * 
 * 2     *   *
 * 
 * 3       *
 * 
 * The Algorithm works in such a way that,
 * the row (0 to 3) prints the stars equal to the 
 * column (0 to 3).
 * 
 * The rest of the stars are printed using 2 constant values i & j.
 * The value of i is give to row and the value of j is given to col.
 * i is increased and j is decreased to get the desired output.
 * 
 * The else block is used to enter spaces between the stars.
 * 
 */

public class v_patt {
	public static void main(String args[]) {
		int i = 0, j = 6;
		
		System.out.println("");
		
		for ( int row = 0 ; row <= 3 ; row++ ) {
			for ( int col = 0 ; col <= 6 ; col++ ) {
				if ( row == col )
					System.out.print("*");
				else if ( row == i  &&  col == j ) {
					System.out.print("*");
					i += 1;
					j -= 1;
				}
				else
					System.out.print(" ");
			}
			System.out.println("");
		}
	}
}
