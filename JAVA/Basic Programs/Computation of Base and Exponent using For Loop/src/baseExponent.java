import java.util.Scanner;

public class baseExponent {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int result = 1;
		
		System.out.print("\n Enter the base number : ");
		int base = sc.nextInt();
		
		System.out.print("\n Enter the exponent value : ");
		int exponent = sc.nextInt();
		
		for (; exponent != 0; exponent--)
			result *= base;
		
		System.out.println("\n Answer = " + result);
	}

}
