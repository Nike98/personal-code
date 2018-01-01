/*
 * ############################################################################
 * ############################################################################
 * 
 * 				This program here demonstrates the use of the 
 * 						  'this' keyword in JAVA. 
 * 
 * ############################################################################
 * ############################################################################
*/

public class main_class {

	public static void main(String[] args) {
		Example_class Eg_object = new Example_class();
		
		System.out.println(" Before using \'this\' keyword ....\n");
		Eg_object.Display_values();
		
		System.out.println("\n After using \'this\' keyword ....\n");
		Eg_object.Set_Values(30, "Changed Name");
		Eg_object.Display_values();
	}

}
