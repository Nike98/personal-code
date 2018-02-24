/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program here Takes the input from the User
 * 		to insert an element within the Array at a 
 * 		specified position within the Array.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class insert_element {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();				// Getting the size of the Array input by the User
		
		int arr[] = new int[size];
		
		System.out.println(" Enter the " + " Elements of the Array : ");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();				// Getting the Elements of the Array input by the User
		}
		
		System.out.print("\n Enter the Element to be Inserted : ");
		int element = inp.nextInt();					// Getting the input of the Element to be Inserted by the User
		
		System.out.print("\n Enter the Position at which the Element is to be Inserted : ");
		int position = inp.nextInt();			// Getting the Position of the Element to be Inserted within the Array 
		
		if ( position > size )
			System.out.println("\n Array position out of bounds...");
		else {
			for ( int i = size ; i > position ; i-- ) {
				arr[i + 1] = arr[i];			// Shift all Elements to the right starting at point -1 
			}
			
			arr[position] = element;
			
			System.out.println("\n Array After Inserting the Element : \n");
			
			for ( int loop : arr ) {
				System.out.println(" " + loop);
			}
		}
	}

}
