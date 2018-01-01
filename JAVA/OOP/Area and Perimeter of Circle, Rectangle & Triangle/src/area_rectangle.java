
public class area_rectangle {
	
	private double length, breadth;
	
	public void Input_Rect (double len, double bre) {
		length = len;
		breadth = bre;
	}
	
	public void Area_Rect () {
		double area;
		area = length * breadth;									// Formula for the calculation of the Area of Rectangle
		
		System.out.println("\n The Area of the Rectangle = " + area);
	}
	
	public void Perimeter_Rect () {
		double peri;
		peri = 2 * (length + breadth);								// Formula for the calculation of the Perimeter of Rectangle
		
		System.out.println("\n The Perimeter of the Rectangle = " + peri);
	}
}
