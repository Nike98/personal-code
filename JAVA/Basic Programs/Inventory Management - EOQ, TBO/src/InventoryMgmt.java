
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 		Main aim is to demonstrate the use of the Math.sqrt() method. 
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class InventoryMgmt {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("\n Enter the Demand Rate: ");
		double demandRate = sc.nextDouble();
		
		System.out.print(" Enter the Setup Cost: ");
		double setupCost = sc.nextDouble();
		
		System.out.print(" Enter the Holding Cost: ");
		double holdingCost = sc.nextDouble();
		
		System.out.println("\n\n Economic Order Quantity (EOQ): " + 
							((Math.sqrt(2 * demandRate * setupCost)) /
									(Math.sqrt(holdingCost))));
		
		System.out.println(" Optimal Time Between Orders (TBO): " + 
							((Math.sqrt(2 * setupCost)) / 
									Math.sqrt(holdingCost * demandRate)));
	}

}
