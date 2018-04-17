/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to create and generate a Thread to generate 
 * 		10 terms of Fibonacci Series.
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s4q2 {

	public static void main(String[] args) {
		
		Thread obj = new Thread(new Runnable() {

			@Override
			public void run() {
				
				int first, second, next = 0, i;
				first = 0;
				second = 1;
				
				for ( i = 1 ; i <= 10 ; i++ ) {
					System.out.println(" " + first);
					
					next = first + second;
					first = second;
					second = next;
				}
			
			}
		});
		
		obj.start();
	}

}
