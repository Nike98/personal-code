
public class Car {

	private String color;
	private String body;
	
	public Car() {
		color = "blue";
		body = "Sedan";
	}
	
	public Car(String color, String body) {
		this.color = color;
		this.body = body;
	}
	
	public String toString() {
		return " " + color + " " + body + ".";
	}

}
