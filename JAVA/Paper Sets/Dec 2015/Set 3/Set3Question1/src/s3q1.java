/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP which will accept a Number as Command Line Argument
 * 		from the User and check whether it is prime or not.
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s3q1 {

	public static void main(String[] args) {
		
		int num = Integer.parseInt(args[0]);
		int rem, i;
		boolean flag = false;
		
		if ( num == 0 || num == 1 )
			System.out.println("\n It is not a Prime Number");
		else {
			
			rem = num / 2;
			
			for ( i = 2 ; i <= rem ; i++ ) {
				
				if ( num % i == 0 ) {
					
					System.out.println("\n It is not a Prime Number");
					flag = true;
				}
			}
		}
		
		if ( !flag )	// This means if (flag == 0) or (flag == false)
			System.out.println("\n It is a Prime Number");
	}

}
