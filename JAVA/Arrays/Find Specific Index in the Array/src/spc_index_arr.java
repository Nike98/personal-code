/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to find the Index of an Array Element
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class spc_index_arr {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();							// Asking the User for the number of indexes needed
		
		int arr[] = new int[size];							// Providing the integer Array with the user input size
		
		System.out.println("\n Enter the " + size + " Elements of the Array : ");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();
		}
		
		System.out.print("\n Enter the Array Element to check the Index Value : ");
		int arr_elem = inp.nextInt();						// Taking input for the Array Element whose index is to be derived
		
		int index_val = 0;
		boolean flag = false;
		
		for ( int i = 0 ; i < size ; i++ ) {
			if ( arr_elem == arr[i] ) {
				index_val = i;
				flag = true;
			}
		}
		
		if ( !flag ) 
			System.out.println("\n The Array value entered does not Exist so does the Index Value.");
		else
			System.out.println("\n The Array Value entered is present and the Index value = " + index_val);
	}

}
