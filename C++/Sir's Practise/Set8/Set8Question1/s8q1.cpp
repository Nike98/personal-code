///
/**
  * ##############################################
  *
  *     WAP to find Area and perimeter of
  *      Square and Triangle by creating
  *       the class 'Shape' , 'Square' ,
  *       'Triangle' and required data
  *         members and function like
  *          inputvalues() and area().
  *
  * ##############################################
**/
///

#include <iostream>

using namespace std;

class Shape
{
public:
    virtual void InputValues() = 0;
    virtual void Area() = 0;
};

class Square : public Shape
{
private:
    int side;
public:
    void InputValues()
    {
        int s;
        side = s;

        cout << "\n ------------------------------------------------------------------- \n" << endl;
        cout << " Enter the Side if the Square : ";
        cin >> side;
    }

    void Area()
    {
        cout << "\n ------------------------------------------------------------------- \n" << endl;
        cout << " The Area of the Square = " << side * side << endl;
    }
};

class Triangle : public Shape
{
private:
    float base, height;
public:
    void InputValues()
    {
        float b, h;
        base = b;
        height = height;

        cout << "\n ------------------------------------------------------------------- \n" << endl;
        cout << " Enter the Base of the Triangle : ";
        cin >> base;
        cout << " Enter the Height of the Triangle : ";
        cin >> height;
    }

    void Area()
    {
        cout << " The Area of the Triangle = " << 0.5 * base * height << endl;
        cout << "\n ------------------------------------------------------------------- \n" << endl;
    }
};

int main ()
{
    Square SqObj;
    Triangle TriObj;

    SqObj.InputValues();
    TriObj.InputValues();
    SqObj.Area();
    TriObj.Area();

    return 0;
}
