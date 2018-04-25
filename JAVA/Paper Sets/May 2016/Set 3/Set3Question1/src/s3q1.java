/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to read file 'text1.txt' using FileInputStream class
 * 		and Display it's contents on the Command Prompt.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class s3q1 {

	public static void main(String[] args) throws IOException {
		
		try {
			
			FileInputStream fis = new FileInputStream("C:/Users/Nikhil/Downloads/text1.txt");
			
			int data = 0;
			
			while ( (data = fis.read()) != -1 ) {
				
				System.out.print((char)data);
			}
			
			fis.close();
			
		} catch (FileNotFoundException e) {
			
			e.printStackTrace();
		}
	}

}
