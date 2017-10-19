#include <iostream>
#include <conio.h>

using namespace std;

float pie = 3.142857;

class Shape
{
private:
    float radius, length, width, base, height, side[3];
public:
    void Input ()
    {
        float rad, len, wid, b, h, s[3];
        radius = rad;
        length = len;
        width = wid;
        base = b;
        height = h;
        side[3] = s[3];

        cout << " ***** CIRCLE *****" << "\n\n";
        cout << " Enter the Radius of the Circle : ";           // Taking the input for the Radius of the Circle
        cin >> radius;
        cout << "\n\n";

        cout << " ***** RECTANGLE *****" << "\n\n";
        cout << " Enter the Length of the Rectangle : ";        // Taking the input for the Length of the Rectangle
        cin >> length;
        cout << " Enter the Width of the Rectangle : ";         // Taking the input for the Width of the Rectangle
        cin >> width;
        cout << "\n\n";

        cout << " ***** TRIANGLE *****" << "\n\n";
        cout << " Enter the Base of the Triangle : ";           // Taking the input for the Base of the Triangle
        cin >> base;
        cout << " Enter the Height of the Triangle : ";         // Taking the input for the Height of the Triangle
        cin >> height;
        cout << "\n Enter the 1st Side of the Triangle : ";           // Taking the input for all the Sides of the Triangle
        cin >> side[1];
        cout << " Enter the 2nd Side of the Triangle : ";
        cin >> side[2];
        cout << " Enter the 3rd Side of the Triangle : ";
        cin >> side[3];
        cout << "\n\n";
    }

    void AreaCalculator ()
    {
        float areaCircle, areaRectangle, areaTriangle;

        cout << " ********** AREA OF ALL THE SHAPES **********" << "\n\n\n";    // Printing the Area of all the above Shapes

        cout << " ***** CIRCLE *****" << "\n\n";
        areaCircle = pie * radius * radius;                     // Formula for Area of the Circle
        cout << " The Area of the Circle = " << areaCircle << endl;
        cout << "\n\n";

        cout << " ***** RECTANGLE *****" << "\n\n";
        areaRectangle = length * width;                          // Formula for Area of the Rectangle
        cout << " The Area of the Rectangle = " << areaRectangle << endl;
        cout << "\n\n";

        cout << " ***** TRIANGLE *****" << "\n\n";
        areaTriangle = (0.5 * base) / height;                   // Formula for the Area of the Triangle
        cout << " The Area of the Triangle = " << areaTriangle << endl;
        cout << "\n\n";
    }

    void PerimeterCalculator ()
    {
        float periCircle, periRectangle, periTriangle;

        cout << " ********** PERIMETER OF ALL THE SHAPES **********" << "\n\n\n";    // Printing the Perimeter of all the above Shapes

        cout << " ***** CIRCLE *****" << "\n\n";
        periCircle = 2 * (pie * radius);                        // Formula for the Perimeter of the Circle
        cout << " The Perimeter of the Circle = " << periCircle << endl;
        cout << "\n\n";

        cout << " ***** RECTANGLE *****" << "\n\n";
        periRectangle = 2 * (length + width);                   // Formula for the Perimeter of the Rectangle
        cout << " The Perimeter of the Rectangle = " << periRectangle << endl;
        cout << "\n\n";

        cout << " ***** TRIANGLE *****" << "\n\n";
        periTriangle = side[1] + side[2] + side[3];
        cout << " The Perimeter of the Triangle = " << periTriangle << endl;
        cout << "\n";
    }
};

int main ()
{
    Shape Calculator;
        Calculator.Input();
        Calculator.AreaCalculator();
        Calculator.PerimeterCalculator();

    getch();
}
