
public class area_triangle {

	private double base, height, side1, side2, side3;
	
	public void Input_Tri (double b, double h, double s1, double s2, double s3) {
		base = b;
		height = h;
		side1 = s1;
		side2 = s2;
		side3 = s3;
	}
	
	public void Area_Tri () {
		double area;
		area = 0.5 * base * height;									// Formula for the calculation of the Area of Triangle
		
		System.out.println("\n The Area of the Triangle = " + area);
	}
	
	public void Perimeter_Tri () {
		double peri;
		peri = side1 + side2 + side3;								// Formula for the calculation of the Perimeter of Triangle
		
		System.out.println("\n The Perimeter of the Triangle = " + peri);
	}
}
