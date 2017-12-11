/*
 *      0    1    2    3    4
 * 
 * 0    *    *    *    *    *
 * 
 * 1              *
 * 
 * 2              *
 * 
 * 3              *
 * 
 * 4              *
 * 
 * 5              *
 * 
 * 6              * 
 * 
 * Here, the 1st statement in the if condition prints 
 * the stars in the 2nd column of the pattern.
 * 
 * The 2nd statement prints the stars in the 
 * 0th row excluding the 2nd column.
 * 
 */
public class t_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( (col == 2)  || (row == 0 && col != 2) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
