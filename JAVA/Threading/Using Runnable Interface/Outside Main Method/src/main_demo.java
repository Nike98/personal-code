/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This program prints 1 to 10 using 2 threads.
 * 
 * 			This program runs the Threads using a Runnable
 * 			interface within a class whose object/instance
 * 			is created in the main method.
 * 
 * ############################################################################
 * ############################################################################
*/

class DemoClass implements Runnable{

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
	}
	
}


public class main_demo {

	public static void main(String[] args) {
		
		Thread obj1 = new Thread(new DemoClass());
		Thread obj2 = new Thread(new DemoClass());
		
		obj1.start();
		obj2.start();
	}

}
