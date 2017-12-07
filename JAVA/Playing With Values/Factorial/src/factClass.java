import java.util.Scanner;

public class factClass {
	public static void main (String args[]) {
		int i, num;
		long f = 1;						// Only works till 20
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter the Digit : ");
		num = inp.nextInt();
		
		for ( i = 1 ; i <= num ; i++ ) {
			f *= i;
		}
		
		System.out.println("\n The Factorial = " +f);
	}
}
