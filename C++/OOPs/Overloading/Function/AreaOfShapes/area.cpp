#include <iostream>

using namespace std;

float pie = 3.142857;

void Area ( float radius )            // Function for the Area of the Circle
{
    float arCircle;

    arCircle = pie * radius * radius;

    cout << "\n" << " The Area of the Circle = " << arCircle << endl;
}

void Area ( int length, int breadth )           // Function for the Area of Rectangle
{
    float arRectangle;

    arRectangle = length * breadth;

    cout << " The Area of the Rectangle = " << arRectangle << endl;
}

void Area ( float base, float height )            // Function for the Area of the Triangle
{
    float arTriangle;

    arTriangle = (0.5 * base) / height;

    cout << " The Area of the Triangle = " << arTriangle << endl;
}

int main ()
{
    Area (5.5);
    Area (5, 10);
    Area (2.5f, 5.5f);

    return 0;
}
