/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program takes input from the User of the 
 *	 	rows and columns in the 1st and the 2nd Matrix,
 * 		multiplies both of the matrices and 
 * 		displays a new matrix as the product to the User.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class multiply_matrices {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number of Rows in the 1st Matrix : ");
		int row1 = inp.nextInt();						// Input the number of rows in the first Matrix
		
		System.out.print(" Enter the Number of Columns in the 1st Matrix : ");
		int col1 = inp.nextInt();						// Input the number of column in the first Matrix
		
		// Initializing the first Matrix
		int first[][] = new int[row1][col1];
		
		// Getting the Elements input for the fist matrix
		
		System.out.println("\n Enter the Elements for the 1st Matrix : \n");
		
		for ( int i = 0 ; i < row1 ; i++ ) {
			for ( int j = 0 ; j < col1 ; j++ ) {
				first[i][j] = inp.nextInt();
			}
		}
		
		// Displaying the first matrix
		
		System.out.println("\n The 1st Matrix : ");
		
		for ( int i = 0 ; i < row1 ; i++ ) {
			for ( int j = 0 ; j < col1 ; j++ ) {
				System.out.print(" " + first[i][j] + "\t");
			}
			System.out.println();
		}
		
		System.out.print("\n Enter the Number of Rows in the 2nd Matrix : ");
		int row2 = inp.nextInt();						// Input the number of rows in the second Matrix
		
		System.out.print(" Enter the Number of Columns in the 2nd Matrix : ");
		int col2 = inp.nextInt();						// Input the number of column in the second Matrix
		
		/*
		 * if the row of the second matrix and the column of the 
		 * first matrix are not equal to each other then the whole process 
		 * will be abandoned and the following message will be displayed.
		 */
		if ( row2 != col1 )
	         System.out.println("\n Matrices with entered orders can't be multiplied with each other.");
		
		else {
			
			int sum = 0;
			
			// Initializing the second Matrix
			int second[][] = new int[row2][col2];
			
			// Declaring the multiply matrix to store and display the product
			int multiply[][] = new int[row1][col2];
			
			// Getting the Elements input for the second matrix
			
			System.out.println("\n Enter the Elements for the 2nd Matrix : \n");
			
			for ( int i = 0 ; i < row2 ; i++ ) {
				for ( int j = 0 ; j < col2 ; j++ ) {
					second[i][j] = inp.nextInt();
				}
			}
			
			// Displaying the second matrix
			
			System.out.println("\n The 2nd Matrix : ");
			
			for ( int i = 0 ; i < row1 ; i++ ) {
				for ( int j = 0 ; j < col1 ; j++ ) {
					System.out.print(" " + second[i][j] + "\t");
				}
				System.out.println();
			}
			
			// Multiplying both the matrices
			
			for ( int i = 0 ; i < row1 ; i++ ) {
				for ( int j = 0 ; j < col2 ; j++ ) {
					for ( int k = 0 ; k < row2 ; k++ ) {
						sum += first[i][k] * second[k][j];
					}
					
					multiply[i][j] = sum;
					sum = 0;
				}
			}
			
			// Displaying the product of the matrices
			
			System.out.println("\n The Product of the Matrices : \n");
			
			for ( int i = 0 ; i < row1 ; i++ ) {
				for ( int j = 0 ; j < col2 ; j++ ) {
					System.out.print(" " + multiply[i][j] + "\t");
				}
				
				System.out.println();
			}
		}
	}

}
