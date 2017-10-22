//
/*
 * Write a simple C++ Abstract Class Shape
 * which will have pure virtual
 * method called Area
*/
//

#include <iostream>

using namespace std;

class Shape
{
public:
    virtual void Area () = 0;
};

class ArSquare : public Shape
{
private:
    int side;
public:
    void Input ()
    {
        int s;
        side = s;

        cout << " Enter the Side of the Square : ";
        cin >> side;
    }

    void Area ()
    {
        int arSquare;

        arSquare = side * side;

        cout << "\n The Area of the Square = " << arSquare << endl;
    }
};

int main ()
{
    ArSquare obj;

    obj.Input();
    obj.Area();

    return 0;
}
