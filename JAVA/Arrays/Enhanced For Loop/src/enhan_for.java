/*
 * ############################################################################
 * ############################################################################
 * 
 * 				An Enhanced For Loop is a for loop which does 
 * 					  not require all the 3 conditions 
 * 			   (required by a for loop normally) to be written.
 * 
 * 				  It can work with just a data identifier 
 * 				and an initialized/previously stored array.
 * 
 * 				As mentioned above, the array either be initialized or 
 * 				scanned using a normal for loop in an array identifier.
 * 
 * 				This type of loop is mostly used to print the 
 * 				  array, sum it up, or do basic math within.
 * 
 * ############################################################################
 * ############################################################################
*/

public class enhan_for {

	public static void main(String[] args) {
		int arr[] = {1,2,3,4,5,6};
		int sum = 0;
		
		for ( int count : arr ) {
			sum += count;
		}
		
		System.out.println(" The sum of all the elements = " + sum);
	}

}
