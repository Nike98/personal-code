import java.util.Scanner;
import java.util.Arrays;

public class fibon {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("\n Enter the length of the series: ");
		int limit = sc.nextInt();
		
		long[] series = new long[limit];
		series[0] = 0;
		series[1] = 1;
		
		for (int i = 2; i < limit; i++)
			series[i] = series[i - 1] + series[i - 2];
		
		System.out.println("\n The Fibonacci Series is as follows: \n");
		System.out.print(" " + Arrays.toString(series));
	}
}
