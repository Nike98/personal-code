/*
 * ############################################################################
 * ############################################################################
 * 
 * 		 This program is an example of a Multidimensional Array Table.
 * 
 * 					Here, the Arrays are initialized and 
 * 					function is used to Display the Table.
 * 
 * ############################################################################
 * ############################################################################
*/

public class multi_dim_arr {

	public static void main(String[] args) {
		int arr1[][] = {{1,2,3,4,5},{6,7,8},{9,10,11,12,13,14,15}};
		int arr2[][] = {{100,101,102,103},{104,105},{106},{108,109,110}};
		
		System.out.println(" The 1st Array is : ");
		
		Display_arr ( arr1 );
		
		System.out.println("\n The 2nd Array is : ");
		
		Display_arr ( arr2 );
	}
	
	public static void Display_arr( int this_arr[][] ) {
		for ( int row = 0 ; row < this_arr.length ; row++ ) {
			for ( int col = 0 ; col < this_arr[row].length ; col++ ) {
				System.out.print(" " + this_arr[row][col] + "\t");
			}
			System.out.println();
		}
	}
}
