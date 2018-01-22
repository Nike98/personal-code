import java.util.Scanner;

public class primeNoCheck {
	public static void main (String args[]) {
		int num, i, flag = 0;
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter the Number : ");
		num = inp.nextInt();
		
		for ( i = 2 ; i <= num / 2 ; i++ ) {
			if ( num % i != 0 ) {
				flag = 1;
				break;
			}
		}
		
		if ( flag == 1 )
			System.out.println(" It is a Prime Number.");
		else
			System.out.println(" It is Not a Prime Number.");
	}
}
