///
/**
 *      WAP to demonstrate a use of virtual destructor.
 */
///

#include<iostream>

using namespace std;

class Base
{
public:
    Base() { cout << "Constructing Base.\n"; }

    virtual ~Base() { cout << "Destructing Base.\n"; }
};

class Derived: public Base
{
public:
    Derived()  { cout << "Constructing Derived.\n"; }

    ~Derived() { cout << "Destructing Derived.\n"; }
};

int main()
{
    Derived *derv = new Derived();
    Base *base = derv;

    delete base;

    return 0;
}
