/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to accept a word from the User on the Command Line
 * 		and remove the duplicate characters from it.
 * 
 * 		For eg. - I/p = abcdabc, O/p = abcd
 * 				  I/p = javaforschoolisgood, O/p = javforschligd
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class s3q1 {

	public static void main(String[] args) {
		
		Scanner inp = new Scanner(System.in);
		
		System.out.print(" Enter the String : ");
		String str_with_duplicates = inp.nextLine();		// Input the main string which contains all the duplicate characters also
		
		char[] all_chars = str_with_duplicates.toCharArray();	// Implicitly converting the String to a Char Array
		
		boolean found[] = new boolean[256];		// Includes a boolean array of 256 spaces
		
		/*
		 * String Builder is a String class which is used 
		 * to create a mutable (or modifiable) strings.
		 */
		StringBuilder strbuild = new StringBuilder();
		
		// For Each/Enhanced For loop to check all the characters one by one for duplicates
		for ( char c : all_chars ) {
			
			if ( !found[c] ) {
				
				/*
				 * This approach utilizes the ASCII value of characters. 
				 * 
				 * The given string is converted to a character array which is iterated to determine 
				 * duplicate characters. 
				 * 
				 * In each iteration, the character is checked for existence in a boolean array. 
				 * This boolean array converts the character to its numeric equivalent and 
				 * checks for the value at this numeric index. 
				 * 
				 * If the character has not appeared previously, then the value at this position 
				 * will be false(since boolean array will have all false values by default). 
				 * Now the value is set to true and the character is appended to the java.util.StringBuilderobject. 
				 * 
				 * Next time when the same character appears the value at the index equal 
				 * to its numeric value is found true and nothing happens.
				 * The boolean array is initialized to a capacity of 256 keeping in mind the ASCII values.
				 */
				found[c] = true;
				strbuild.append(c);
			}
		}
		
		System.out.println("\n The String w/o Duplicates : " + strbuild);
	}

}
