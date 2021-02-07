import java.util.Scanner;

public class swapNoThird {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("\n Enter the first number : ");
		int num1 = sc.nextInt();
		
		System.out.print("\n Enter the second number : ");
		int num2 = sc.nextInt();
		
		num1 = num1 + num2;
		num2 = num1 - num2;
		num1 = num1 - num2;
		
		System.out.println("\n The outputs after Swapping are :- \n");
		System.out.println(" First number : " + num1);
		System.out.println(" Second number : " + num2);
	}

}
