/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to create and run the following threads: 
 * 			1. To print Letter 'A' 10 times.
 * 			2. To print Letter 'B' 10 times.
 * 			3. To print integers from 1 to 60.
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s3q2 {

	public static void main(String[] args) {
		
		Thread objA = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 0 ; i < 10 ; i++ ) {
					System.out.println(" A");
				}
			}
			
		});
		
		Thread objB = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 0 ; i < 10 ; i++ ) {
					System.out.println(" B");
				}
			}
			
		});
		
		Thread objrun = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 1 ; i <= 60 ; i++ ) {
					System.out.println(" " + i);
				}
			}
			
		});
		
		objA.start();
		objB.start();
		objrun.start();
		
		try {
			objA.join(0);
			objB.join(0);
			objrun.join(0);
		} catch (InterruptedException e) {
			
			e.printStackTrace();
		}
	}

}
