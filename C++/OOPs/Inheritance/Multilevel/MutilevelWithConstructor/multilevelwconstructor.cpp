#include <iostream>

using namespace std;

class A
{
public:
    A ()
    {
        cout << " The Constructor of Class A is being called." << endl;
    }
};

class B : public A
{
public:
    B ()
    {
        cout << " The Constructor of Class B is being called." << endl;
    }
};

class C : public B
{
public:
    C ()
    {
        cout << " The Constructor of Class C is being called." << endl;
    }
};

int main ()
{
    C obj;

    return 0;
}
