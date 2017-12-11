/*
 *      0    1    2    3    4
 * 
 * 0         *    *    *    
 * 
 * 1    *                   
 * 
 * 2    *                   
 * 
 * 3         *    *    *                 
 * 
 * 4                		*        
 * 
 * 5                        *
 * 
 * 6     	 *	  *    *
 * 
 * Here, in the 1st statement of the if condition, we
 * print the stars in the 0th, 3rd and 6th row, 
 * excluding the 0th and the 4th column.
 * 
 * The 2nd statement prints the stars in the
 * 0th column of the pattern, excluding all
 * the other rows and columns except the 
 * 1st and the 2nd row and the 0th column itself.
 * 
 * The 3nd statement prints the stars in the
 * 4th column of the pattern, excluding all
 * the other rows and columns except the 
 * 4st and the 5nd row and the 4th column itself.
 * 
 */
public class s_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 5 ; col++ ) {
				if ( ((row == 0 || row == 3 || row == 6) && (col > 0 && col < 4))  ||  (col == 0 && ( row > 0 && row < 3))  ||  (col == 4 && (row > 3 && row < 6)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
