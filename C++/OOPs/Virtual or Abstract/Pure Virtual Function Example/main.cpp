///
/**
 *      WAP to demonstrate the use of Pure Virtual Function
 */
///

#include<iostream>

using namespace std;

class Base
{
public:
    virtual void Show() = 0;
};

class Derived: public Base
{
public:
    void Show() { cout << "In Derived.\n"; }
};

int main()
{
    Base *b = new Derived();
    b->Show();

    return 0;
}
