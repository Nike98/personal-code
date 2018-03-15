/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to test if Array contains a Specific Value
 * 
 * 			Also known as Linear Search !!!
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class linear_search_algo {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		int i;
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();			// Getting the size of the Array input from the User
		
		int arr[] = new int[size];
		
		System.out.println("\n Enter the values in the Array : \n");
		
		for ( i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();			// Getting the values in the Array list input from the User
		}
		
		System.out.print("\n Enter the Value to be Checked : ");
		int value = inp.nextInt();			// Getting the value to find input from the User
		
		for ( i = 0 ; i < size ; i++ ) {
			/*
			 * if the value input to search is found then
			 * the code will generate the following output
			 */
			if ( arr[i] == value ) {
				System.out.println("\n The Value " + value + " Exists at index no " + (i+1));
				break;
			}
		}
		
		/*
		 * if the value entered to search is out of bounds
		 * or is non existent within the Array then 
		 * the following code will be executed
		 */
		if ( i == size ){
			System.out.println("\n The Value does not Exist");
		}
		
	}

}
