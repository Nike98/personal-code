/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to accept 10 integers from the user and Arrange
 * 		them in Descending order and display it.
 *  
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class s4q1 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		int arr[] = new int[10];
		
		System.out.println("\n Enter the 10 Elements : \n");
		
		for ( int i = 0 ; i < 10 ; i++ ) {
			
			arr[i] = inp.nextInt();
		}
		
		System.out.println("\n The Array before getting Sorted : \n");
		
		for ( int loop : arr )
			System.out.print(" " + loop);
		
		// Bubble Sort in Descending Order
		for ( int i = 0 ; i < 10 ; i++ ) {
			
			for ( int j = 0 ; j < 10 - i - 1 ; j++ ) {
				
				if ( arr[j] < arr[j + 1] ) {
					
					int swap = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = swap;
				}
			}
		}
		
		System.out.println("\n\n The Array after getting Sorted : \n");
		
		for ( int loop : arr )
			System.out.print(" " + loop);
	}

}
