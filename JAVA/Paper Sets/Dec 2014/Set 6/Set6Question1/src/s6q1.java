/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to accept roll number, name, marks on Command Line.
 * 		Design a suitable class which represents student information.
 * 		According to the value of marks(between 1 to 100) the class
 * 		should be given to the student 
 * 		(Fail, Pass class, Second Class, First Class, Distinction).
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class s6q1 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Name of the Student : ");
		String name = inp.nextLine();
		
		System.out.print("\n Enter the Roll Number of the Student : ");
		int roll_no = inp.nextInt();
		
		System.out.print("\n Enter the Marks of the Student : ");
		int marks = inp.nextInt();
		
		String msg;
		
		if ( marks > 90 )
			msg = "Distinction";
		
		else if ( marks > 80 )
			msg = "First Class";
		
		else if ( marks > 70 )
			msg = "Second Class";
		
		else if ( marks > 50 )
			msg = "Pass Class";
		
		else
			msg = "Fail";
		
		System.out.println("\n Result of " + name + " is : " + msg);
	}

}
