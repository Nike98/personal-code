
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a program to create a Custom Exception PayOutofBound 
 * 			and fire it. The program should take employee name and basic 
 * 			salary as input. If basic salary is less than 5000 fire the 
 * 			exception or else calculate the gross salary
 * 			Note:
 * 				DA is 17% of Basic salary
 * 				HRA is 50% of basic salary
 * 				deduction is 5% of basic salary
 * 				gross=BASIC+DA+HRA
 * 				net=gross-deduction
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class EmployeeSalary {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		try {
			System.out.print("\n Enter the Employee name: ");
			String name = sc.nextLine();
			
			System.out.print(" Enter the basic Salary: ");
			double basic_sal = sc.nextDouble();
			
			double da, hra, deduct, gross, net;
			
			if (basic_sal < 5000)
				throw new PayOutOfBoundsException("\n ERROR: Minimum salary payable should be 5000.");
			else {
				da = basic_sal * 0.17;
				hra = basic_sal * 0.5;
				deduct = basic_sal * 0.05;
				gross = basic_sal + da + hra;
				net = gross - deduct;
				
				System.out.println("\n Gross Salary: " + gross);
				System.out.println(" Net salary: " + net);

			}
		} catch (PayOutOfBoundsException e) {
			System.out.println("\n " + e.getMessage());
		}
	}

}
