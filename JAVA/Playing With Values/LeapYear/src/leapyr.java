import java.util.Scanner;

public class leapyr {
	public static void main (String args[]) {
		int year;
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter the Year : ");
		year = inp.nextInt();
		
		if ( year % 4 == 0 ) {
			System.out.println(" " + year + " is a Leap Year");
		}
		else{
			System.out.println(" " + year + " is not a Leap Year");
		}
	}
}
