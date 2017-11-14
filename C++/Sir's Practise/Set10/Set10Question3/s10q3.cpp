///
/**
  *##############################################
  *
  *     WAP to calculate Area of Rectangle,
  *       Cube and Cylinder using Class.
  *
  *##############################################
**/
///

#include <iostream>
#include <math.h>

using namespace std;

class Rectangle
{
private:
    int length, breadth;
public:
    Rectangle ()
    {
        cout << "\n -------------------------------------------------------------- \n" << endl;
        cout << " Enter the Length of the Rectangle : ";
        cin >> length;
        cout << " Enter the Breadth of the Rectangle : ";
        cin >> breadth;
    }

    void AreaRectangle ()
    {
        cout << "\n -------------------------------------------------------------- \n" << endl;
        cout << " The Area of the Rectangle = " << length * breadth << endl;
    }
};

class Cube
{
private:
    int side;
public:
    Cube ()
    {
        cout << "\n -------------------------------------------------------------- \n" << endl;
        cout << " Enter the Side of the Cube = ";
        cin >> side;
    }

    void AreaCube ()
    {
        cout << " The Area of the Cube = " << 6 * pow(side, 2) << endl;
    }
};

class Cylinder
{
private:
    float height, radius;
    float pi = 3.142857;
public:
    Cylinder ()
    {
        cout << "\n -------------------------------------------------------------- \n" << endl;
        cout << " Enter the Height of the Cylinder : ";
        cin >> height;
        cout << " Enter the Radius of the Cylinder : ";
        cin >> radius;
    }

    void AreaCylinder ()
    {
        cout << " The Area of the Cylinder = " << (2 * pi * radius * height) + (2 * pi * pow(radius, 2)) << endl;
        cout << "\n -------------------------------------------------------------- \n" << endl;
    }
};

int main ()
{
    Rectangle objRectangle;
    Cube objCube;
    Cylinder objCylinder;

    objRectangle.AreaRectangle();
    objCube.AreaCube();
    objCylinder.AreaCylinder();

    return 0;
}
