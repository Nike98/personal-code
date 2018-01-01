import java.util.Scanner;

public class arr_tbl_usr_inp {

	public static void main(String[] args) {
		Scanner inp = new Scanner (System.in);
		
		System.out.println(" Enter the Number of Indexes/Elements in te Array : ");
		int size = inp.nextInt();							// Asking the User for the number of indexes needed
		
		int arr[] = new int[size];							// Providing the integer Array with the user input size
		
		System.out.println("\n Enter the " + size + " Elemnts of te Array : ");
		
		for ( int count = 0 ; count < size ; count++ ) {
			arr[count] = inp.nextInt();						// Scanning and saving the user inputs
		}
		
		System.out.println("\n The Array Entered by the User :");
		
		for ( int count = 0 ; count < size ; count++ ) {
			System.out.println(" " + arr[count]);			// Displaying the saved array
		}
	}

}
