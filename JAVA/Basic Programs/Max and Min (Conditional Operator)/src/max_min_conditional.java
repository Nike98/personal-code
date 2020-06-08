import java.util.Scanner;

public class max_min_conditional {
	public static void main (String args[]) {
		int num1, num2;
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the 1st value : ");
		num1 = inp.nextInt();
		System.out.print(" Enter the 2nd value : ");
		num2 = inp.nextInt();
		
		int res = num1 > num2 ? num1 : num2;
		
		System.out.println("\n The Maximum value = " + res);
	}
}
