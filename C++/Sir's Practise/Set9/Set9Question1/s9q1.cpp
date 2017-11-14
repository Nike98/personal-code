///
/**
  *##############################################
  *
  *           WAP to overload '++' and
  *                '--' operator
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

class Number
{
private:
    int num;
public:
    void getNum(int x)                      /// Function to get the Number
    {
        num = x;
    }

    void Display()                          /// Displaying the Number
    {
        cout << " The value of num is " << num << endl;
    }

    void operator ++ ()                     /// Unary operator ++ Overloading
    {
        num = ++num;
    }

    void operator -- ()                     /// Unary operator -- Overloading
    {
        num = --num;
    }
};

int main ()
{
    Number obj;

    obj.getNum(10);
    ++obj;

    cout << " After Increment - ";
    obj.Display();
    cout << endl;

    --obj;
    cout << " After Decrement - ";
    obj.Display();
    cout << endl;

    return 0;
}
