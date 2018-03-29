/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to Create a Package Games. Add classes Cricket, Hockey and 
 *		Football in it. Add appropriate methods in each class which
 * 		accepts and displays of players for that game. Create a class
 * 		GameDemo which imports the package Game in it, and uses the 
 * 		classes from it.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import Games.Cricket;
import Games.Hockey;
import Games.Football;

public class Game_Demo {

	public static void main(String[] args) {
		
		Cricket objCricket = new Cricket();
		Hockey objHockey = new Hockey();
		Football objFootball = new Football();
		
		objCricket.Input();
		objHockey.Input();
		objFootball.Input();
		
		System.out.println("\n The Information of the Cricket Players : \n");
		objCricket.Display();
		
		System.out.println("\n The Information of the Hockey Players : \n");
		objHockey.Display();
		
		System.out.println("\n The Information of the Football Players : \n");
		objFootball.Display();
	}

}
