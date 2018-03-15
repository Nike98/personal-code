/*
 * ############################################################################
 * ############################################################################
 * 
 * 			WAP to test if Array contains a Specific Value
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;

public class spc_val_arr {

	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Size of the Array : ");
		int size = inp.nextInt();
		
		int arr[] = new int[size];
		
		System.out.println("\n Enter the values in the Array : \n");
		
		for ( int i = 0 ; i < size ; i++ ) {
			arr[i] = inp.nextInt();
		}
		
		System.out.print("\n Enter the Value to be Checked : ");
		int value = inp.nextInt();
		boolean flag = false;
		
		for ( int check : arr ) {
			if ( check == value )
				flag = true;
			else
				flag = false;
		}
		
		if (!flag)
			System.out.println("\n The Value does Not Exists");
		else
			System.out.println("\n The Value Exists");
	}

}
