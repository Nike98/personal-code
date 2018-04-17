/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP that reads a lowercase string from the Command Line
 * 		and writes the string to a file "uppercase.txt" in UpperCase.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;

public class s2q2 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter a String : ");
		String data = inp.nextLine();
		
		File file = new File("C:\\Users\\Nikhil\\Documents\\Uppercase.txt");
		
		try {
			
			if ( !file.exists() ) 
				file.createNewFile();
			
			PrintWriter printw = new PrintWriter(file);
			printw.println(data.toUpperCase());
			printw.close();
			
			System.out.println("\n Done !");
			
		}catch( IOException ex ) {
			
			ex.printStackTrace();
		}
	}

}
