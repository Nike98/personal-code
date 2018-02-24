/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program takes input from the User in an Array,
 * 		Reverses it and Displays it to the User.
 * 
 * ############################################################################
 * ############################################################################
*/

public class rev_array {

	public static void main(String[] args) {
		
		int arr[] = {1, 2, 3, 4, 5};
		
		System.out.println(" The Current Array : \n");
		
		for (int loop : arr)
			System.out.println(" " + loop);
		
		rev_method(arr, 0, 4);
		
		System.out.println("\n The Reversed Array : \n");
		
		for (int loop : arr)
			System.out.println(" " + loop);
	}
	
	public static void rev_method ( int arr[], int start, int end ) {
		
		int temp;
		
		if ( start >= end ) 
			return;
		
		temp = arr[start];
		arr[start] = arr[end];
		arr[end] = temp;
		
		rev_method(arr, start+1, end-1);
	}

}
