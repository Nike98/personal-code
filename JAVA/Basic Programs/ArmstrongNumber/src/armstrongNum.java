import java.util.Scanner;

public class armstrongNum {
	public static void main (String args[]) {
		int og_num, num, digit, sum = 0;
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter a positive integer : ");
		og_num = inp.nextInt();
		
		num = og_num;
		
		while ( num != 0 ) {
			digit = num % 10;
			sum += Math.pow(digit, 3);
			num /= 10;
		}
		
		if ( sum == og_num ) {
			System.out.println(" It is an Armstrong Number.");
		}
		else {
			System.out.println(" It is Not an Armstrong Number.");
		}
	}
}
