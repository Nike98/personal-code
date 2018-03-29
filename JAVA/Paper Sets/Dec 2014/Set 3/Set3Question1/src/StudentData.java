/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to do the following : 
 * 			1. Accept name, marks in 3 subjects as Command Line Arguments
 * 			2. Create a class Student with methods total() and percent()
 * 			3. Class StudentData creates instance of student and prints
 * 			   name, total and percentage of the Student.
 * 
 * ######################################################################################
 * ######################################################################################
*/

public class StudentData {

	public static void main(String[] args) {
		
		String name = args[0];
		int marks1 = Integer.parseInt(args[1]);
		int marks2 = Integer.parseInt(args[2]);
		int marks3 = Integer.parseInt(args[3]);
		
		try {
			
			if ( (marks1 >= 0 && marks1 <= 100) || (marks2 >= 0 && marks2 <= 100) || (marks3 >= 0 && marks3 <= 100) ) {
				
				Student obj = new Student(marks1, marks2, marks3);
				
				int total = obj.total();
				double percentage = obj.percent();
				
				System.out.println("\n Name: " + name + "\n Total:  " + total + "\n Percentage: " + percentage + "% ");
			}
			
			else
				throw new ArithmeticException("Input out of Bounds.");
		}catch ( Exception e ) {
			
			e.getLocalizedMessage();
		}
		
	}

}
