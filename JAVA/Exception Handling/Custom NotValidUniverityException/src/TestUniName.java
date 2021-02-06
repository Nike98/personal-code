
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a Java program to create your own exception 
 * 			(NotValidUniversityException) when username is not 
 * 			University of Mumbai.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class TestUniName {

	public static void main(String[] args) {
		Scanner s=new Scanner(System.in);
		
		System.out.print("\n Enter username: ");
		String username = s.nextLine();
		
		try
		{
			if(!username.equals("University of Mumbai"))
			throw new NotValidUniversityException("\n Enter valid university.");
			System.out.println("\n Welcome to University of Mumbai");
		}
		catch(NotValidUniversityException e)
		{
			System.out.println(e.getMessage());
		}
	}

}
