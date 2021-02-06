
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a Java program to demonstrate multiple catch 
 * 			blocks with their order according to specific exception. 
 * 			Also demonstrate the propagation of a Checked Exception.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class MultipleCatch {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		try {
			// ArithmeticException
			System.out.print("\n Enter the first number: ");
			int num1 = sc.nextInt();
			System.out.print(" Enter the second number: ");
			int num2 = sc.nextInt();
			
			int output = num1 / num2;
			System.out.println("\n Result: " + output);
			
			// ArrayIndexOutOfBoundsException
			int data[] = {4,8,5,9,2};
			System.out.print("\n\n Enter the index number to show it's data: ");
			int index = sc.nextInt();
			
			if(data.length < index - 1)
				throw new ArrayIndexOutOfBoundsException();
			else
				System.out.println("\n Data at the index is: " + data[index-1]);
			
			// ParentException
			String s = null;
            System.out.println(s.length());


		} catch (ArithmeticException e) {
			System.out.println("\n ERROR: Arithmetic Exception occured.");
		} catch(ArrayIndexOutOfBoundsException e)
        {
			System.out.println("\n ERROR: ArrayIndexOutOfBounds Exception");
        } catch(Exception e)
        {
            System.out.println("\n ERROR: Parent Exception.");
        }


	}

}
