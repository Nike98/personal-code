
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 		WAP to implement user defined exception Marks out of bounds 
 * 		(Marks should not be greater than 100)
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class MarksMain {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		int marks;
		
		try
		{
			System.out.print("\n Enter marks: ");
			marks = sc.nextInt();
			
			if(marks > 100)
			throw new MarksOutOfBoundsException(null);
			
			System.out.println("\n Marks entered: " + marks);
		}
		catch(MarksOutOfBoundsException e)
		{
			e.showErrorMessage();
		}

	}

}
