import java.util.Scanner;

public class NumofDigits {
	public static void main (String args[]) {
		int count = 0, num;
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number : ");
		num = inp.nextInt();
		
		while ( num != 0 ) {
			num /= 10;
			count++;
		}
		System.out.println(" The Number of Digits Entered are : " + count);
	}
}
