///
/**
  * WAP to show Binary Operator Overloading '+'
**/
///

#include <iostream>

using namespace std;

class Add
{
private:
    int a, b;
public:
    Add ( int val_a, int val_b )
    {
        a = val_a;
        b = val_b;
    }

    Add operator + ( Add obj )
    {
        Add temp;

        temp.a = a + obj.a;
        temp.b = a + obj.b;

        return temp;
    }

    void Display ()
    {
        cout << " " << a << endl << " " << b << endl;
    }
};

int main ()
{
    Add object_a (5, 2), object_b(2, 3);

    Add MainObj = object_a + object_b;

    MainObj.Display();

    return 0;
}
