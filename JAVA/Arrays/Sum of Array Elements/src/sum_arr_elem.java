
public class sum_arr_elem {

	public static void main(String[] args) {
		int arr[] = {2,9,3,4,6,10,40};									// Initialization of the Array
		int sum = 0;
		
		for ( int count = 0 ; count < arr.length ; count++ ) {
			sum += arr[count];											// Calculation of all the elements
		}
		
		System.out.println(" The Sum of the Array = " + sum);			// Printing the Sum
	}

}
