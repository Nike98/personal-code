/*
 *     0   1   2   3   4   5   6
 * 
 * 0   *                       *
 * 
 * 1   *   *               *   *
 * 
 * 2   *       *       *       *
 * 
 * 3   *           *           *
 * 
 * 4   *                       *
 * 
 * 5   *                       *
 * 
 * 6   *                       *
 * 
 * Here, in this program we 1st print the left hand side stars,
 * and with that we print the right hand stars using 
 * the condition ((col == 0) || (col == 6)).
 * 
 * Then we use the 2nd block of condition to
 * print the left diagonal line of stars.
 * 
 * The last condition block prints the stars as specified clearly !
 * 
 * The lse block is there for spaces.
 * 
 */

public class m_patt {
	public static void main (String args[]) {
		
		System.out.println("");
		
		for ( int row = 0 ; row < 7 ; row++ ) {
			for ( int col = 0 ; col < 7 ; col++ ) {
				if ( ( (col == 0) || (col == 6) )  ||  ((row == col) && (col > 0  &&  col < 4))  ||  ((row == 1 && col == 5) || (row == 2 && col == 4)) ) {
					System.out.print(" *");
				}
				else
					System.out.print("  ");
			}
			System.out.println("");
		}
	}
}
