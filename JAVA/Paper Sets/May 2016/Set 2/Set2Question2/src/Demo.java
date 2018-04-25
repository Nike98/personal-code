/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Write a class which will accept String from the Command Line.
 * 		If length of the String is more than 10 characters then fire 
 * 		"IllegalLengthException". Also check if any number is passed 
 * 		then fire "NumberParameterException".
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class Demo {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print("\n Enter the String : ");
		String str = inp.nextLine();
		
		try {
			
			if ( str.length() > 10 ) 
				throw new IllegalLengthException("String Length out of Bounds");
			
			else if ( str.matches(".*\\d+.*") )		// To check if the String has a number in it
				throw new NumberParameterException("String contains one or more Digits");
			
			else
				System.out.println("\n " + str);
			
		}catch(IllegalLengthException | NumberParameterException e) {
			
			System.out.println("\n " + e.getMessage());
			
		}
	}

}
