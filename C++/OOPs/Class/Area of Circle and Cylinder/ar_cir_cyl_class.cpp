#include <iostream>
#include <conio.h>
#include <math.h>

using namespace std;

float pie = 3.142857;

class Cylinder
{
private:
    float radiusCy, height;
public:
    void CylInp ()
    {
        float radCy, hgt;
        radiusCy = radCy;
        height = hgt;

        cout << " Enter the Radius of the Cylinder : ";
        cin >> radiusCy;
        cout << "\n Enter the Height of the Cylinder : ";
        cin >> height;
        cout << endl;
    }

    void CylCalc ()
    {
       float arCy, radpowCy;
       radpowCy = pow(radiusCy, 2);
       arCy = (2 * pie * radiusCy * height) + (2 * pie * radpowCy);
       cout << " The Area of the Cylinder = " << arCy << "\n\n\n";
    }
};

class Cube
{
private:
    int SideCube;
public:
    void CubeInp ()
    {
        int sCube;
        SideCube = sCube;

        cout << " Enter the Side of the Cube : ";
        cin >> SideCube;
        cout << "\n";
    }

    void CubeCalc ()
    {
        float arCube, powCube;
        powCube = pow(SideCube, 2);
        arCube = 6 * powCube;
        cout << " The Area of the Cube = " << arCube << "\n\n";
    }
};

int main ()
{
    Cylinder cylinder;
        cylinder.CylInp();
        cylinder.CylCalc();
    Cube cube;
        cube.CubeInp();
        cube.CubeCalc();

    getch();
}
