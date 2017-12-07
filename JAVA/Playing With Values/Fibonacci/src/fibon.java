import java.util.Scanner;

public class fibon {
	public static void main (String args[]) {
		int num, first, second, next = 0, i;
		first = 0;
		second = 1;
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the Number : ");
		num = inp.nextInt();
		System.out.println("");
		
		for ( i = 1 ; i <= num ; i++ ) {
			System.out.println(" " + first);
			
			next = first + second;
			first = second;
			second = next;
		}
	}
}
