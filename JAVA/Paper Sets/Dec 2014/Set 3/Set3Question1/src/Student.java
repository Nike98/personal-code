
public class Student {
	
	private int marks1;
	private int marks2;
	private int marks3;

	public Student(int m1, int m2, int m3) {
		
		marks1 = m1;
		marks2 = m2;
		marks3 = m3;
	}
	
	public int total () {
		
		int sum = marks1 + marks2 + marks3;
		
		return sum;
	}
	
	public double percent() {
		
		int sum = total();
		
		double per = sum * 100 / 300;
		
		return per;
	}
}
