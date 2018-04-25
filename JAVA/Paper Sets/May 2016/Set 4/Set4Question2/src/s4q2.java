/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Design 4 Overloaded forms of the following methods.
 * 		Overload forms should be as per the following signatures:
 * 
 * 		(a) int sum(int, int)
 * 		(b) float sum(float, float)
 * 		(c) long sum(long, long)
 * 		(d) double sum(double, double)
 * 		(e) String (String, String) // Strings Concatenated
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class s4q2 {

	public static void main(String[] args) {
		
		over_load obj = new over_load();
		
		System.out.println(" The Integer Sum = " + obj.sum(5, 7));
		System.out.println(" The Float Sum = " + obj.sum(2.25, 3.75));
		System.out.println(" The Long Sum = " + obj.sum(11111, 22222));
		System.out.println(" The Double Sum = " + obj.sum(5.7525252, 9.2484848));
		System.out.println(" The String Sum = " + obj.sum("This", "That"));
	}

}
