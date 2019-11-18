///
/**
 *      WAP to demonstrate runtime polymorphism(Virtual Functions)
 */
///

#include<iostream>

using namespace std;

class Base
{
public:
    virtual void Show() { cout << "Entered Base.\n"; }
};

class Derived: public Base
{
public:
    void Show() { cout << "Entered Derived." << endl; }
};

int main()
{
    Derived obj;

    obj.Show();     // signifies run-time polymorphism

    return 0;
}
