import java.util.Scanner;

public class paldrm {
	public static void main(String args[]) {
		int num, og_num, rem, rev = 0;
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number : ");
		num = inp.nextInt();
		og_num = num;
		
		while ( og_num != 0 ) {
			rem = og_num % 10;
			rev = ( rev * 10 ) + rem;
			og_num /= 10;
		}
		
		if (num == rev)
			System.out.println(" " + num + " is a Pallindrome Number.");
		else
			System.out.println(" " + num + " is Not a Pallindrome Number.");
	}
}
