import java.util.Scanner;

public class basic_calc {
	public static void main ( String args[]) {
		int num1, num2, choice, i = 1, res;
		
		Scanner inp = new Scanner (System.in);
		
		while ( i != 0 ) {
			System.out.println("\n\t Menu");
			System.out.println(" 1. Addition");
			System.out.println(" 2. Subtraction");
			System.out.println(" 3. Multiplication");
			System.out.println(" 4. Division");
			System.out.println(" 5. Exit");
			System.out.print(" Enter your choice : ");
			choice = inp.nextInt();
			
			switch ( choice ){
			case 1 : System.out.print(" Enter the 1st value : ");
					 num1 = inp.nextInt();
					 System.out.print(" Enter the 2nd value : ");
					 num2 = inp.nextInt();
					 res = num1 + num2;
					 System.out.print(" The Addition = " + res + "\n\n");
					 break;
					 
			case 2 : System.out.print(" Enter the 1st value : ");
			 		 num1 = inp.nextInt();
			 		 System.out.print(" Enter the 2nd value : ");
			 		 num2 = inp.nextInt();
			 		 res = num1 - num2;
			 		 System.out.print(" The Subtraction = " + res + "\n\n");
			 		 break;
			 		 
			case 3 : System.out.print(" Enter the 1st value : ");
			 		 num1 = inp.nextInt();
			 		 System.out.print(" Enter the 2nd value : ");
			 		 num2 = inp.nextInt();
			 		res = num1 * num2;
			 		 System.out.print(" The Multiplication = " + res + "\n\n");
			 		 break;
			 		
			case 4 : System.out.print(" Enter the 1st value : ");
			 		 num1 = inp.nextInt();
			 		 System.out.print(" Enter the 2nd value : ");
			 		 num2 = inp.nextInt();
			 		 res = num1 / num2;
			 		 System.out.print(" The Addition = " + res + "\n\n");
			 		 break;
			 		 
			default :System.out.println(" You Chose to Exit...");
					 i = 0;
					 break;
			}
		}
	}
}
