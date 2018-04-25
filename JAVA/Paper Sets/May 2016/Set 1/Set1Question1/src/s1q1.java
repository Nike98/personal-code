/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Write 3 different Threads counting from 1 to 100,
 * 		101 to 200 and 201 to 300 and start them together.
 * 		Give them different priorities and see which one 
 * 		finishes first.
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s1q1 {

	public static void main(String[] args) {
		
		// Thread for 1 to 100
		Thread obj1 = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 1 ; i <= 100 ; i++ ) {
					System.out.println(" " + i);
				}
			}
			
		});
		
		// Thread for 101 to 200
		Thread obj2 = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 101 ; i <= 200 ; i++ ) {
					System.out.println(" " + i);
				}
			}
			
		});
		
		// Thread for 201 to 300
		Thread obj3 = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 201 ; i <= 300 ; i++ ) {
					System.out.println(" " + i);
				}
			}
			
		});
		
		obj1.setPriority(Thread.MAX_PRIORITY);
		obj2.setPriority(Thread.NORM_PRIORITY);
		obj3.setPriority(Thread.MIN_PRIORITY);
		
		obj1.start();
		obj2.start();
		obj3.start();
		
		try {
			obj1.join();
			obj2.join();
			obj3.join();
		} catch (InterruptedException e) {
			
			e.printStackTrace();
		}

	}

}
