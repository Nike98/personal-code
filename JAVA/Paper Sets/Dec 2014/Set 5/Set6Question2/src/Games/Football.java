package Games;

import java.util.Scanner;

public class Football {

	private String[] players = new String[5];
	private Scanner inp = new Scanner(System.in);
	
	public void Input() {
		
		System.out.println("\n Enter the Name of 5 Players in Football : \n");
		
		for ( int i = 0 ; i < 5 ; i++ ) {
			
			players[i] = inp.nextLine();
		}
	}
	
	public void Display() {
		
		for ( String loop : players ) {
			
			System.out.println(" " + loop);
		}
	}
}
