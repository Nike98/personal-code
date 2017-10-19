#include <iostream>

using namespace std;

class Base
{
private:
    int a, b;
public:
    void Input ();
    void Output ();
};

class Parent : public Base
{
    void Input()
    {
        int val1, val2;

        val1 = a;
        val2 = b;

        cout << " Enter the 1st value : ";
        cin >> val1;
        cout << "\n Enter the 2nd value : ";
        cin >> val2;
    }

    void Output()
    {
        int sum;

        sum = val1 + val2;

        cout << "\n\n The Sum of the Inputs = " << sum << endl;
    }
};

int main ()
{
    Parent obj;

    obj.Input();
    obj.Output();

    retunr 0;
}
