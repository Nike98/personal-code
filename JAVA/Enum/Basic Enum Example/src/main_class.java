/*
 * ############################################################################
 * ############################################################################
 * 
 * 			Enums or Enumerations serve the purpose of representing 
 * 			 a group of named constants in a programming language.
 * 						Their value cannot be changed.
 * 
 * ############################################################################
 * ############################################################################
*/

public class main_class {

	public static void main(String[] args) {
		for ( prog_lang languages : prog_lang.values() )
			System.out.printf(" %s\t\t%s\t\t%s\n", languages, languages.getDeveloper(), languages.getPopularity());
	}

}
