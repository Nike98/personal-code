/*
 * ############################################################################
 * ############################################################################
 * 
 * 				This here is an example of a set of particular
 * 						Enum constants to be displayed.
 * 
 * 			  This is done by importing the EnumSet namespace and
 * 		   using the EnumSet.range(from, to) function in the namespace.
 * 
 * ############################################################################
 * ############################################################################
*/

import java.util.EnumSet;

public class range_display {

	public static void main(String[] args) {
		System.out.println(" The range of constatnts ...\n");
		
		for ( prog_lang languages : EnumSet.range(prog_lang.C_Sharp, prog_lang.MATLAB) )
			System.out.printf(" %s\t\t%s\t\t%s\n", languages, languages.getDeveloper(), languages.getPopularity());
	}

}
