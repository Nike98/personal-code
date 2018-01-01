
public class area_circle {
	
	public double pi = 3.142857;								// Global variable declaration of PI value
	private double radius;
	
	public void Input_Cir (double r) {
		radius = r;
	}
	
	public void Area_Circle () {
		double area;
		area = pi * Math.pow(radius, 2);						// Formula for the calculation of the Area of Circle
		
		System.out.println("\n The Area of te Circle = " + area);
	}
	
	public void Perimeter_Cir () {
		double peri;
		peri = 2 * (pi * radius);								// Formula for the calculation of the Perimeter of Circle
		
		System.out.println("\n The Perimeter of te Circle = " + peri);
	}
}
