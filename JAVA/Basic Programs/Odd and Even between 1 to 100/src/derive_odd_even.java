
/*
 * This class here, derives the Even and Odd
 * numbers from the range of 1 - 100
 * using all the specified loops.
 */

public class derive_odd_even {
	
	public static void using_for_loop () {
		for ( int num = 1 ; num <= 100 ; num++ ) {
			if ( num % 2 != 0 )
				System.out.print("\t " + num);
			else 
				System.out.println("\t  " + num);
		}
	}
	
	public static void using_while_loop () {
		int num = 1;
		while ( num <= 100 ) {
			if ( num % 2 != 0 )
				System.out.print("\t " + num);
			else 
				System.out.println("\t  " + num);
			num++;
		}
	}
	
	public static void using_do_while () {
		int num = 1;
		
		do {
			if ( num % 2 != 0 )
				System.out.print("\t " + num);
			else 
				System.out.println("\t  " + num);
			num++;
		}while ( num <= 100 );
	}
}
