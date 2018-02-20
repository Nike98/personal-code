/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This program prints 1 to 10 using 2 threads.
 * 
 * 			This program runs the Threads using a Runnable
 * 			interface within the main method.
 * 
 * ############################################################################
 * ############################################################################
*/
public class MyClass {

	public static void main(String[] args) {
		
		Thread obj = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 0 ; i < 10 ; i++ ) {
					System.out.println(" The Thread id: " + Thread.currentThread().getId() + "\t Value = " + i);
				}
				
				try {
					Thread.sleep(500);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}});
		
		obj.start();
	}

}
