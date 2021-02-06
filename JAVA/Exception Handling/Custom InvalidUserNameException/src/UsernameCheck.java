
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a java program to create user defined exception, 
 * 			check if name is "suresh" else throw exception.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class UsernameCheck {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		System.out.print("\n Enter name: ");
		String username = s.nextLine();
		
		try
		{
			if(!username.equals("suresh"))
			throw new InvalidUserNameException("\n Enter the correct name!");
			System.out.println("\n Welcome, Suresh!");
		}
		catch(InvalidUserNameException e)
		{
			System.out.println(e.getMessage());
		}
	}

}
