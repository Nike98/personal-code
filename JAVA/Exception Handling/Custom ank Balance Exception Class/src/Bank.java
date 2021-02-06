
/*
 * ################################################################################################
 * ################################################################################################
 * 
 * 			Write a program to create your own exception for the 
 * 			banking transaction, when a customer withdraws an amount 
 * 			from the bank, the system will check an appropriate balance 
 * 			of Rs. 1000/- is maintained with bank and when customer deposits 
 * 			an amount exceeds Rs. 50000/-, system asks for PAN Card details.
 * 
 * ################################################################################################
 * ################################################################################################
*/

import java.util.Scanner;

public class Bank {

	public static void main(String[] args) {
		try {
			Scanner sc = new Scanner(System.in);

			int bal = 48000;
			int n;
			String n1;
			int ch;

			do {
				System.out.print("\n 1. Deposit"
						+ "\n 2. Withdraw" 
						+ "\n 3. Exit" 
						+ "\n Enter your choice: ");
				ch = sc.nextInt();
				System.out.println();
				
				switch (ch) {
				case 1:
					System.out.print(" Enter the amount to deposit: ");
					n = sc.nextInt();
					
					if ((bal + n) > 50000) {
						System.out.print("\n Enter your PAN Card details: ");
						String details = sc.next();
						
						bal += n;
						
						System.out.println("\n Current balance: " + bal);
					} else {
						bal += n;
						System.out.println("\n Current balance: " + bal);
					}
					break;

				case 2:
					System.out.print(" Enter the amount to withdraw: ");
					n = sc.nextInt();
					
					if ((bal - n) < 1000)
						throw new CustomException("\n Minimum balance should be Rs.1000");
					else {
						bal -= n;
						System.out.println("\n Current balance: " + bal);
					}
					break;
				}
			} while (ch != 3);
		} catch (Exception e) {
			System.out.println("\n Warning:" + e.getMessage());
		}
	}

}
