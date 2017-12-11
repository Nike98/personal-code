import java.util.Scanner;

public class reverse_num {
	public static void main (String args[]) {
		int num, og_num, rem, rev_num = 0;
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter the Number : ");
		num = inp.nextInt();
		
		og_num = num;
		
		while ( og_num != 0 ) {
			rem = og_num % 10;
			rev_num = (rev_num * 10) + rem;
			og_num /= 10;
		}
		
		System.out.println(" The Reversed Number = " + rev_num);
	}
}
