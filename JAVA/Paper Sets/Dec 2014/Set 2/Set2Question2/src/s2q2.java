/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 		WAP to do the following : 
 * 
 * 		String val = "PGDCA Pune University Examinations"
 * 
 * 			1. Find the second instance of the index of 'P'
 * 			2. Find the last instance of the index of 'E'
 * 			3. Find out the character at position 12
 * 			4. Replace all 'a' in a string with 'Z'
 * 			5. Trim all leading and trailing spaces from the string " Hello world "
 * 			6. Create String s1: Have a nice day
 * 			7. Create String s2: PGDCA students
 * 			8. Concatenate the above strings
 * 			9. Convert the concatenated string to upper case
 * 			10. Have an instance of StringBuffer as "World" and reverse the string
 * 
 * ################################################################################################
 * ################################################################################################
*/
public class s2q2 {

	public static void main(String[] args) {
		
		String val = "PGDCA Pune University Examinations"; 
		
		// 1. Find the second instance of the index of 'P'
		int index_of_P = secondInstance (val);
		System.out.println(" The 2nd instance of the \"P\" is at index : " + index_of_P);
		
		//2. Find the last instance of the index of 'E'
		int lst_index_E = lastInstance(val);
		
		System.out.println("\n The last instance of \"E\" is at the index : " + lst_index_E);
		
		// 3. Find out the character at position 12
		System.out.println("\n The character at the 12th position is : " + val.charAt(12));
		
		// 4. Replace all 'a' in a string with 'Z'
		System.out.println("\n The Replaced String : " + val.replaceAll("a", "Z"));
		
		// 5. Trim all leading and trailing spaces from the string " Hello world "
		String str = " Hello world ";
		
		// This is sort of a built in function to remove all the white spaces in a string
		System.out.println("\n The String \"Hello world\" without whitespaces : " + str.replaceAll("\\s", ""));
		
		/*
		 * 6. Create String s1: Have a nice day
 * 		 * 7. Create String s2: PGDCA students
 * 		 * 8. Concatenate the above strings
		 */
		
		String s1 = " Have a nice day";
		String s2 = " PGDCA Students";
		
		System.out.println("\n The Concatenated Strings are : " + s1.concat(s2)); 
		// or you can use the concatenation operator "+" as: s1 + s2
		
		// 9. Convert the concatenated string to upper case
		System.out.println("\n The String to UpperCase : " + s1.toUpperCase() + s2.toUpperCase());
		
		// 10. Have an instance of StringBuffer as "World" and reverse the string
		String strbuff = "World";
		
		System.out.println("\n The Reversed String : " + ReverseString(strbuff));
	}
	
	public static int secondInstance ( String val ) {
		
		/*
		 * Normally the indexOf works as such...
		 * 
		 * indexOf(String arg0, int arg1);
		 * Which works as; the string to be checked 
		 * and the index in integer after it has to
		 * be checked .
		 * 
		 * But here, we have overloaded the indexOf function
		 * by giving it a string as the 1st argument and
		 * again using it to derive the 1st instance of "P"
		 * an then +1 as the integer to tell to check it
		 * after that instance. 
		 */
		int index = val.indexOf("P", val.indexOf("P") + 1);
		
		return index;
	}
	
	public static int lastInstance ( String val ) {
		
		int index = val.lastIndexOf("E");
		
		return index;
	}
	
	public static String ReverseString ( String str ) {
		
		String reverse = "";
        
        
        for(int i = str.length() - 1; i >= 0; i--)
        {
            reverse += str.charAt(i);
        }
        
        return reverse;
	}

}
