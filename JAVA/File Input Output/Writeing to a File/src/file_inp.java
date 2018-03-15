/*
 * ############################################################################
 * ############################################################################
 * 
 * 		This program here, displays the method to
 * 		take input from the User for writing 
 * 		any type of characters to a .txt file.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.Scanner;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;

public class file_inp {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the data to be Written to the File : ");
		String data = inp.nextLine();
		
		File file = new File("D:/JavaFile1.txt");
		
		try {
			
			if ( !file.exists() ) 
				file.createNewFile();
			
			PrintWriter printw = new PrintWriter(file);
			printw.println(data);
			printw.close();
			
			System.out.println("\n Done !");
			
		}catch( IOException ex ) {
			
			ex.printStackTrace();
		}
	}

}
