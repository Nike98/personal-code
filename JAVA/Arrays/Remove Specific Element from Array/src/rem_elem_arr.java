/*
 * ############################################################################
 * ############################################################################
 * 
 * 		WAP to remove a specific element from the Array
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class rem_elem_arr {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size : ");
		int size = inp.nextInt();
		
		int arr[] = new int[size];
		int i;
		
		System.out.println("\n Enter the Array Elements : \n");
		
		for ( i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();								// Getting the input from the User
		}
		
		System.out.print("\n Enter the Element to be Deleted : ");
		int del = inp.nextInt();								// Getting the element to be deleted input by the user
		
		int count = 0;
		
		for ( i = 0 ; i < size ; i++ ) {
			if ( arr[i] == del ) {				// Checking if the value to be deleted checked if it exists in the Array
				for ( int j = i ; j < (size - 1) ; j++ ) {
					arr[j] = arr[j + 1];
				}							// Algorithm to delete and merge the new Array
				count++;
				break;
			}
		}
		
		if ( count == 0 )
			System.out.println("\n Element Not Found ..!!!");
		else {
			System.out.println("\n Element Deleted Successfully..!!!");
			System.out.println("\n The New Array : ");
			for ( i = 0 ; i < size - 1 ; i++ ) {
				System.out.println(" " + arr[i]);		// Displaying the new Array
			}
		}
	}

}
