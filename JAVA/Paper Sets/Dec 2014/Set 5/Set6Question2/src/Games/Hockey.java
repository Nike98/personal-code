package Games;

import java.util.Scanner;

public class Hockey {

	private String[] players = new String[5];
	private Scanner inp = new Scanner(System.in);
	
	public void Input() {
		
		System.out.println("\n Enter the Name of 5 Players in Hockey : \n");
		
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
