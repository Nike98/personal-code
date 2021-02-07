import java.util.Scanner;

public class sumProduct {

	public static void main(String[] args) {
int num, og_num, sum = 0, prod = 1;
		
		Scanner inp = new Scanner (System.in);
		
		System.out.print(" Enter the Number : ");
		og_num = inp.nextInt();
		
		num = og_num;
		
		while ( num != 0 ) {
			sum += num % 10;
			prod *= num % 10;
			num /= 10;
		}
		
		System.out.println(" The Sum of the Digits = " + sum);
		System.out.println(" The Product of the Digits = " + prod);
	}

}
