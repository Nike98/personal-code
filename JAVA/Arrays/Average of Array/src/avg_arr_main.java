/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to calculate the Average of an Array
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class avg_arr_main {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();							// Asking the User for the number of indexes needed
		
		int arr[] = new int[size];							// Providing the integer Array with the user input size
		int sum = 0;
		
		System.out.println("\n Enter the " + size + " Elements of the Array : ");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();
			sum += arr[i];									// Deriving the Sum of the Array Elements entered
		}
		
		double average = sum / size;						// Calculating the Average of the Array
		
		System.out.println("\n The Average = " + average);
	}

}
