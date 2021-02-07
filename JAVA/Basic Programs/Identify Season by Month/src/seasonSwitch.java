import java.util.Scanner;

public class seasonSwitch {

	public static void main(String[] args) {
		String season;
		Scanner sc = new Scanner(System.in);
		
	    System.out.print("Enter any month(1 to 12) : ");
	    int month = sc.nextInt();
	    
	     switch (month) 
	     {
	     case 1:
	     case 2:
	     season = "Winter";
	     break;
	     case 3:
	     case 4:
	     case 5:
	     season = "Spring";
	     break;
	     case 6:
	     case 7:
	     case 8:
	     season = "Summer";
	     break;
	     case 9:
	     case 10:
	     case 11:
	     season = "Autumn";
	     break;
	     default:
	     season = "Bogus Month";
	     }
	     
	     System.out.println("The entered month is in the " + season + ".");
	}

}
