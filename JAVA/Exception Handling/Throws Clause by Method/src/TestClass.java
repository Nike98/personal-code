
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 		Program using try catch throw and throws for exception any inbuilt exception
 * 
 * ################################################################################################
 * ################################################################################################
*/

public class TestClass {
	
	static void check() throws ArithmeticException {
		System.out.println("\n Use check() method.");
		throw new ArithmeticException("demo");
	}

	public static void main(String[] args) {
		try {
			check();
		} catch (ArithmeticException e) {
			System.out.println("\n Caught: " + e);
		}
	}

}
