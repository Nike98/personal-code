/*
 *      0    1    2    3    4
 * 
 * 0    *    *    *    *    
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
 * 6    *    *    *    *
 * 
 * Here, in the 1st condition col == 0, we tell the compiler
 * to print stars in the 0th column of the pattern.
 * 
 * The in the 2nd condition we tell the compiler to print the 
 * horizontal stars
 * 
 * The 3rd condition consists of the code to print the stars in the 4th column
 * except row 0 & 6.
 */

public class d_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( ((col == 0) || (col == 4 && row != 0 && row != 6))  ||  ((row == 0 || row == 6) && (col > 0 && col < 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
