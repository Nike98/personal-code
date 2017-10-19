#include <iostream>

using namespace std;

class A
{
public:
    void Calc ();
};

class Inherit : public A
{
public:
    void Calc ()
    {
        int a, b, sum;

        cout << " Enter the value of a : ";
        cin >> a;
        cout << "\n Enter the value of b : ";
        cin >> b;

        sum = a + b;

        cout << "\n\n The Sum = " << sum << endl;
    }
};

int main ()
{
    Inherit obj;

    obj.Calc();

    return 0;
}
