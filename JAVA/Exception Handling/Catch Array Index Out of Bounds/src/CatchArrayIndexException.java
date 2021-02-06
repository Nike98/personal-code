
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a JAVA program to catch ArrayIndexOutOfBoundsException.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class CatchArrayIndexException {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("\n Enter the size of the Array: ");
		int size = sc.nextInt();
		
		int data[] = new int[size];
		
		System.out.println("\n Enter data into the Array: \n");
		for (int i = 0; i < size; i++)
			data[i] = sc.nextInt();
		
		System.out.print("\n Enter the index of the required element: ");
		
		try {
			int index = sc.nextInt();
			System.out.println("\n Element at the index " + index + " is: " + data[index]);
		} catch (ArrayIndexOutOfBoundsException e) {
			System.out.println("\n ERROR: ArrayIndexOutOfBoundsException");
			System.out.println(" The index you have entered is invalid.");
			System.out.println(" Enter an index number between 0-" + size);

		}
	}

}
