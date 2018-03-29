/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to create a Thread Application which prints 
 * 		one character after every second from the string. 
 * 		Following string is passed to the Thread. "JAVA PROGRAMMING".
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s4q2 {

	public static void main(String[] args) {
		
		String str = "JAVA PROGRAMMING";
		
		Thread obj = new Thread(new Runnable() {

			@Override
			public void run() {
				
				for ( int i = 0 ; i < str.length() ; i++ ) {
					
					char ch = str.charAt(i);
					
					System.out.print(ch);
					
					try {
						Thread.sleep(1000);
					} catch (InterruptedException e) {
						
						e.printStackTrace();
					}
				}
			}
			
		});
		
		obj.start();
		
	}
}
