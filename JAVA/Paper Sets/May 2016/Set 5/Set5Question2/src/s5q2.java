/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to append the contents of src.txt to dest.txt
 * 		using Bye Stream classes.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class s5q2 {

	public static void main(String[] args) {
		
		try {
			
			FileInputStream instr = null;
			FileOutputStream outstr = null;
		
			File infile = new File("C:\\Users\\Nikhil\\Documents\\src.txt");
			File outfile = new File("C:\\Users\\Nikhil\\Documents\\dest.txt");
			
			instr = new FileInputStream(infile);
			outstr = new FileOutputStream(outfile);
			
			byte[] buffer = new byte[1024];
			
			int length;
			
			while ( (length = instr.read(buffer)) > 0 ) {
				
				outstr.write(buffer, 0, length);
			}
			
			instr.close();
			outstr.close();
			
			System.out.println(" File Appended Successfully.");
			
		}catch(IOException e) {
			
			e.printStackTrace();
		}
	}

}
