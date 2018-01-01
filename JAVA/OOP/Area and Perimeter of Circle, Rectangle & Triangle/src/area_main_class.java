import java.util.Scanner;

public class area_main_class {
	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);
		
		double rad, l, b, tri_base, tri_height, tri_s1, tri_s2, tri_s3;
		
		area_circle Circle_object = new area_circle();
		area_rectangle Rectangle_object = new area_rectangle();		// Declaring the classes an associating objects to those classes
		area_triangle Triangle_object = new area_triangle();
		
		System.out.println(" ***** CIRCLE *****");
		System.out.print("\n Enter the Radius of the Circle : ");
		rad = inp.nextDouble();										// Taking the Input for the radius of the Circle
		
		System.out.println("\n\n ***** RECTANGLE ***** ");
		System.out.print("\n Enter the Length of the Rectangle : ");
		l = inp.nextDouble();										// Taking input for the length of the Rectangle
		System.out.print("\n Enter the Breadth of the Rectangle : ");
		b = inp.nextDouble();										// Taking input for the breadth of the Rectangle
		
		System.out.println("\n\n ***** TRIANGLE ***** ");
		System.out.print("\n Enter the Base of the Triangle : ");
		tri_base = inp.nextDouble();								// Taking the input for the base of the Triangle
		
		System.out.print(" Enter the Height of the Triangle : ");
		tri_height = inp.nextDouble();								// Taking the input for the height of the Triangle
		
		System.out.print("\n Enter the 1st Side of the Triangle : ");
		tri_s1 = inp.nextDouble();
		
		System.out.print(" Enter the 2st Side of the Triangle : ");	// Taking input for all the sides of the Triangle 
		tri_s2 = inp.nextDouble();
		
		System.out.print(" Enter the 3st Side of the Triangle : ");
		tri_s3 = inp.nextDouble();
		
		Circle_object.Input_Cir(rad);
		Rectangle_object.Input_Rect(l, b);							// Providing the Function in the Class with user inputs
		Triangle_object.Input_Tri(tri_base, tri_height, tri_s1, tri_s2, tri_s3);
		
		/*
		 * 							Printing the Area of all the Shapes 
		 */
		
		System.out.println("\n\n ********** AREA OF ALL THE SHAPES ********** \n\n");
		System.out.println(" ***** CIRCLE ***** \n");
		Circle_object.Area_Circle();
		
		System.out.println("\n ***** RECTANGLE ***** \n");
		Rectangle_object.Area_Rect();
		
		System.out.println("\n ***** TRIANGLE ***** \n");
		Triangle_object.Area_Tri();
		
		/*
		 * 							Printing the Perimeter of all the Shapes
		 */
		
		System.out.println("\n\n ********** PERIMETER OF ALL THE SHAPES ********** \n\n");
		System.out.println(" ***** CIRCLE ***** \n");
		Circle_object.Perimeter_Cir();
		
		System.out.println("\n ***** RECTANGLE *****\n");
		Rectangle_object.Perimeter_Rect();
		
		System.out.println("\n ***** TRIANGLE ***** \n");
		Triangle_object.Perimeter_Tri();
	}

}
