/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program takes the input for the Size and 
 * 		values of two matrices from the User,
 * 		Adds them up and displays the new Matrix to the User.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class add_matrices {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number of Rows in the Matrix : ");
		int row = inp.nextInt();						// Input the number of rows in the Matrix
		
		System.out.print(" Enter the Number of Columns in the Matrix : ");
		int col = inp.nextInt();						// Input the number of column in the Matrix
		
		int first[][] = new int[row][col];
		int second[][] = new int[row][col];				// Declare the 1st, 2nd and the Sum matrix with the row and columns
		int sum[][] = new int[row][col];
		
		System.out.println("\n Enter the Elements of the 1st Matrix : \n");
		
		for ( int i = 0 ; i < row ; i++ ) {
			for  ( int j = 0 ; j < col ; j++ ) {
				first[i][j] = inp.nextInt();			// Input the values in the first matrix
			}
		}
		
		System.out.println("\n Enter the Elements of the 2nd Matrix : \n");
		
		for ( int i = 0 ; i < row ; i++ ) {
			for  ( int j = 0 ; j < col ; j++ ) {
				second[i][j] = inp.nextInt();			// Input the values in the second Matrix
			}
		}
		
		for ( int i = 0 ; i < row ; i++ ) {
			for  ( int j = 0 ; j < col ; j++ ) {
				sum[i][j] = first[i][j] + second[i][j];			// Save the sum of the first and the second matrix in sum
			}
		}
		
		System.out.println("\n Sum of both the Matrices : \n");
		
		for ( int i = 0 ; i < row ; i++ ) {
			for  ( int j = 0 ; j < col ; j++ ) {
				System.out.print(sum[i][j] + "\t");			// Display the new matrix
			}
			
			System.out.println();
		}
	}

}
