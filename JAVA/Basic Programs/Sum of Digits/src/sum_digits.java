import java.util.Scanner;

public class sum_digits {
	public static void main (String args[]) {
		int num, og_num, sum = 0;
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter the Number : ");
		og_num = inp.nextInt();
		
		num = og_num;
		
		while ( num != 0 ) {
			sum += num % 10;
			num /= 10;
		}
		
		System.out.println(" The Sum of the Digits = " + sum);
	}
}
