/*
 * ############################################################################
 * ############################################################################
 * 
 * 			This program increments the value of count
 * 			using Threads executing simultaneously.
 * 
 * 			This program executes the threads together 
 * 			and in the background but the value of count
 * 			is changed using Join and Synchronized.
 * 
 * ############################################################################
 * ############################################################################
*/


public class Demo {

	private static int count = 0;
	
	public static synchronized void increment_count() {
		count++;
	}
	
	public static void main(String[] args) {
		
		Thread obj1 = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 0 ; i < 10000 ; i++ ) {
					increment_count();
				}
				
				try {
					Thread.sleep(500);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}});
		
		Thread obj2 = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 0 ; i < 10000 ; i++ ) {
					increment_count();
				}
				
				try {
					Thread.sleep(500);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}});
		
		obj1.start();
		obj2.start();
		
		try {
			obj1.join();
			obj2.join();
		} catch (InterruptedException e) {
			
			e.printStackTrace();
		}
		
		System.out.println(" The value of count = " + count);
		System.out.println(obj1.isAlive());
		System.out.println(obj2.isAlive());
	}

}
