
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 		Create a class called car. Initialize the color and the body 
 * 		to “blue” and “Sedan” respectively. There should be two constructors. 
 * 		One is the no argument constructor that creates a blue Sedan. 
 * 		The other constructor should take two arguments (color and body). 
 * 		Write a method toString(), which returns the color and the body 
 * 		of the car. Create a subclass funcar. In the subclass also, there 
 * 		are two constructors. First is no-argument constructor and Second 
 * 		constructor is a parameterized constructor. Call the base class 
 * 		constructors from these two subclass constructors. Also write a 
 * 		method named as playMusic() in the subclass that displays the 
 * 		message “Beautiful music fills the passenger compartment”. 
 * 		Execute the methods to display the following:
 * 			“My car is a Blue Sedan.”
 * 			“My brother’s car is a Red Hatchback.”
 * 
 * ################################################################################################
 * ################################################################################################
*/

public class CarsMain {

	public static void main(String[] args) {
		FunCar fun1 = new FunCar();
		System.out.println("\n My car is a" + fun1.toString());
		
		FunCar fun2 = new FunCar("Red", "Hatchnack");
		System.out.println("\n My brother's car is a" + fun2.toString());
	}

}
