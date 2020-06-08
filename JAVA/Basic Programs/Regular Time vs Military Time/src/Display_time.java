/*
 * ############################################################################
 * ############################################################################
 * 
 * 				This program ere demonstrates the use of 
 * 			    String.format() function which is used to 
 * 			  format the way in which a string is displayed.
 * 
 * ############################################################################
 * ############################################################################
*/

public class Display_time {

	public static void main(String[] args) {
		Time_init Time_object = new Time_init();
		
		System.out.println(" Displaying the Time without initializaton....");
		System.out.println("\n Military Time -> " + Time_object.ToMilitary());
		System.out.println(" Regular Time -> " + Time_object.ToRegular());
		
		Time_object.SetTime(19, 42, 25);
		
		System.out.println("\n Displaying the Time with initialization....");
		System.out.println("\n Military Time -> " + Time_object.ToMilitary());
		System.out.println(" Regular Time -> " + Time_object.ToRegular());
	}

}
