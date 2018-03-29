
public class Employee {
	
	private int age;
	private int salary;
	private String name;
	private String address;
	
	public Employee() {
		
		age = 20;
		System.out.println("\n The Age of the Employee: " + age);
	}
	
	public Employee(String n) {
		
		name = n;
		System.out.println("\n The name of the Employee: " + name);
		address = "Ulwe";
		System.out.println("\n The Address of the Employee: " + address);
	}
	
	public void getSalary(int sal) {
		
		salary = sal;
		System.out.println("\n The Salary of the Employee: " + salary);
	}
}
