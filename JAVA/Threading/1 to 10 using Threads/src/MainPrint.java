/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This program prints 1 to 10 using 2 threads.
 * 
 * 			The Thread.sleep() method is used to execute the 
 * 		  	next thread after that much millisecond of interval.
 * 
 * ############################################################################
 * ############################################################################
*/

class DemoClass extends Thread{
	
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

public class MainPrint {

	public static void main(String[] args) {
		
		DemoClass obj1 = new DemoClass();
		obj1.start();
		
		DemoClass obj2 = new DemoClass();
		obj2.start();
	}

}
