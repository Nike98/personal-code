/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Design a suitable class to represent a Bank Account.
 * 
 * 		Include the following Data Members:
 * 			1. Name of the Depositor
 * 			2. Account Number
 * 			3. Type of Account
 * 			4. Balance amount in Account
 * 
 * 		Member Functions:
 * 			1. To assign initial values
 * 			2. To deposit an amount
 * 			3. To withdraw an amount after checking the Balance
 * 			4. To Display name and Balance
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.Scanner;

public class bank {
	
	/*
	 * These variables have been declared Globally 
	 * so that they can be accessed anywhere and
	 * within any method in the the whole code. 
	 */
	
	private static Scanner inp = new Scanner (System.in);
	private static String name;
	private static int acct_no = 1234560;		
	private static String acct_type;
	private static int balance;

	public static void main(String[] args) {
		
		Assign_vals();
		
		int i = 1;
		while(i > 0) {
			System.out.println("\n\n\t\t BANK");
			System.out.println("\n 1. Display Details");
			System.out.println(" 2. Deposit Money");
			System.out.println(" 3. Withdraw Money");
			System.out.println(" 4. Exit");
			System.out.print("\n Enter your choice : ");
			int ch = inp.nextInt();
		
			switch(ch) {
		
			case 1: Display();
			break;
		
			case 2: Deposit();
			break;
		
			case 3: WithDraw();
			break;
		
			default: System.out.println("\n EXIT");
			i = 0;
			break;
		
			}
		}
	}
	
	// This method is created to Assign the values to the global variables declared above
	public static void Assign_vals() {
		
		name = "Nikhil";
		acct_type = "Savings";
		balance = 5000;
	}
	
	/*
	 * This method accepts the amount the User wants to 
	 * deposit in the bank and his Account Number and the
	 * amount is Credited to the User's Account.
	 */
	public static void Deposit() {
		
		System.out.print("\n Enter the Amount to be Deposited : ");
		int deposit = inp.nextInt();
		
		System.out.print("\n Enter the Account Number to be Credited : ");
		int dep_acct_no = inp.nextInt();
		
		if ( dep_acct_no == acct_no ) {
			
			balance += deposit;
			
			System.out.println("\n Deposit Complete. !!");
			System.out.println("\n Amount " + deposit + " Credited to the Account Number " + acct_no);
		}
		else {
		
			System.out.println("\n Wrong or Non Existent Account Number");
		}
	}
	
	/*
	 * This method accepts the Amount the User wants to
	 * Withdraw from the bank and the Account Number for
	 * Verification of the User. If it is wrong then a
	 * Wrong or Non Existent Account Number Message is
	 * shown to the User.
	 * 
	 * If all this is good and the User has sufficient Balance
	 * in his Account then the Amount is Withdrawn. If not then
	 * the User is Informed that there is Low Balance and
	 * he cannot withdraw any money.
	 *
	 */
	public static void WithDraw() {
		
		System.out.print("\n Enter the Amount to be Withdrawn : ");
		int withdraw = inp.nextInt();
		
		System.out.print("\n Enter the Account Number to be Creadited : ");
		int withd_acct_no = inp.nextInt();
		
		if ( withd_acct_no == acct_no ) {
			
			if ( balance > 2000 ) {
				
				balance -= withdraw;
				System.out.println("\n Withdraw Complete. !!");
				System.out.println("\n Amount " + withdraw + " Debited from the Account Number " + acct_no);
			}
			else {
				System.out.println("\n Insufficient Balance.");
				System.out.println(" Transaction cannot be Processed !!");
			}
		}
		else {
			
			System.out.println("\n Wrong or Non Existent Account Number");
		}

	}
	
	/*
	 * This method will Display all the Information
	 * about the User like Name, Account Number,
	 * Account Type and Current Balance in the Account.
	 * 
	 * If the User has Low Balance it will inform the user.
	 */
	public static void Display() {
		
		System.out.println("\n Account Holder's Name : " + name);
		System.out.println(" Account Number : " + acct_no);
		System.out.println(" Account Type : " + acct_type);
		
		if ( balance  <= 2000 ) {
			
			System.out.println(" Current Account Balance : " + balance + "\t LOW BALANCE");
		}
		else
			System.out.println(" Current Account Balance : " + balance);
		
	}

}
