import java.util.Scanner;

public class basicmath {
	public static void main (String args[]) {
		// Declaration of variables.
		int x,y,z;
		
		// Initializing the included Scanner to an object created by the user, 
		// This object is used as a substitute the Scanner class in the whole code.
		// This is a mandatory process in JAVA system applications.
		Scanner input = new Scanner(System.in);
		
		// Getting inputs from the user
		System.out.print(" Enter the value of x : ");
		x = input.nextInt();
		System.out.print(" Enter the value of y : ");
		y = input.nextInt();
		
		// Adding and getting the Sum
		z = x + y;
		
		// Printing the Addition.
		System.out.println(" The Addition = " +z);
		
		// Subtracting the values (as is)
		z = x - y;
		System.out.println(" The Subtraction = " +z);
		
		// Multiplying the values
		z = x * y;
		System.out.println(" The Multiplication = " +z);
		
		// Dividing the values
		z = x / y;
		System.out.println(" The Division = " +z);
	}
}
