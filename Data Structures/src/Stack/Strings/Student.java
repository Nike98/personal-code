package Stack.Strings;

public class Student {
	
	private String name;
	private int roll_no;
	private int age;
	
	public Student(String name, int roll_no, int age) {
		this.name = name;
		this.roll_no = roll_no;
		this.age = age;
	}
	
	public String toString() {
		return "Name: " + this.name + "\n"
				+ "Roll No: " + this.roll_no + "\n"
				+ "Age: " + this.age;
	}
}
