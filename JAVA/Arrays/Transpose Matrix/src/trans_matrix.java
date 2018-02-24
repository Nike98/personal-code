/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program here Takes the input from the User
 * 		to insert elements within the Matrix and 
 * 		Transposes the Matrix and Displays it to the User.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class trans_matrix {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number of Rows in the Matrix : ");
		int row = inp.nextInt();						// Input the number of rows in the Matrix
		
		System.out.print(" Enter the Number of Columns in the Matrix : ");
		int col = inp.nextInt();						// Input the number of columns in the Matrix
		
		int matrix[][] = new int[row][col];
		
		System.out.println("\n Enter the Elements of the Matrix : \n");
		
		for ( int i = 0 ; i < row ; i++ ) {
			for  ( int j = 0 ; j < col ; j++ ) {
				matrix[i][j] = inp.nextInt();			// Input the values in the matrix
			}
		}
		
		// Displaying the Matrix
		System.out.println("\n The Entered Matrix is : \n");
		
		for ( int i = 0 ; i < row ; i++ ) {
			for  ( int j = 0 ; j < col ; j++ ) {
				System.out.print(" " + matrix[i][j]);
			}
			System.out.println();
		}
		
		// Transposing the Matrix
		int transpose[][] = new int[col][row];
		
		for ( int i = 0 ; i < row ; i++ ) {
			for ( int j = 0 ; j < col ; j++ ) {
				transpose[j][i] = matrix[i][j];
			}
		}
		
		// Displaying the Transposed Matrix
		System.out.println("\n The Transposed Matrix is : \n");
		
		for ( int i = 0 ; i < col ; i++ ) {
			for ( int j = 0 ; j < row ; j++ ) {
				System.out.print(" " + transpose[i][j]);
			}
			System.out.println();
		}
	}

}
