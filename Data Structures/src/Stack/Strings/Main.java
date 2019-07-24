package Stack.Strings;

public class Main {

	public static void main(String[] args) {
		StudentStack stack = new StudentStack();
		
		Student student1 = new Student("Nikhil", 25, 21);
		Student student2 = new Student("Yash", 40, 25);
		
		stack.push(student1);
		stack.push(student2);
		
		System.out.println(student1.toString() + "\n");
		System.out.println(student2.toString());
	}

}
