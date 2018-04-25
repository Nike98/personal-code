
public class Orange extends Fruit implements Squeezable {

	private static String fruit_type;
	
	public Orange(String name) {
		super(name);
		fruit_type = "Citric";
	}
	
	@Override
	public void canSmell() {
		
		System.out.println("\n It can Smell");
	}
	
	public void Display() {
		
		System.out.println("\n Name : " + name);
		System.out.println(" Type of Fruit : " + fruit_type);
	}
}
