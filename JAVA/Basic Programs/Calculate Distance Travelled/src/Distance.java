
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 		The total distance travelled by a vehicle in t seconds is given 
 * 		by distance = ut + (at2 )/2 where u is the initial velocity 
 * 		(meters per second), a is the acceleration (meters per second2 ).
 * 		Write a program to evaluate the distance travelled at regular 
 * 		intervals of time, given the values of u and a. The Program 
 * 		should provide the flexibility to the user to select his own 
 * 		time intervals and repeat the calculations for different values of u and a.
 * 
 * 		Main aim is to demonstrate the use of the Math.pow() method.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class Distance {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		double dist = 0.0;
		
		System.out.print("\n Enter the number of Intervals: ");
		int interval = sc.nextInt();
		
		for (int i = 1; i <= interval; i++) {
			System.out.println("\n Interval: " + i);
			System.out.print(" Enter the Time in seconds: ");
			int sec = sc.nextInt();
			
			System.out.print(" Enter the Velocity: ");
			double velocity = sc.nextDouble();
			
			System.out.print(" Enter the Acceleration: ");
			double accel = sc.nextDouble();
			
			dist += (velocity * sec + (accel * (Math.pow(sec, 2))) / 2);
		}
		System.out.println("\n\n Total Distance Travelled: " + dist);
	}

}
