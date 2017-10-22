///
/**
  * WAP to accept 2 numbers
  * and display the sum
  * using Constructor
**/
///

#include <iostream>

using namespace std;

class Add
{
private:
    int a, b;
public:
    Add ()
    {
        cout << " Enter the value of a : ";
        cin >> a;
        cout << " Enter the value of b : ";
        cin >> b;
    }

    void Display ()
    {
        cout << "\n The Sum = " << a + b << endl;
    }
};

int main ()
{
    Add obj;

    obj.Display();

    return 0;
}
