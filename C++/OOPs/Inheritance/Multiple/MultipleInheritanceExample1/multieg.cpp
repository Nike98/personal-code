#include <iostream>

using namespace std;

class Parent1
{
public:
    Parent1 ()
    {
        cout << " The Parent1 Class is called." << endl;
    }
};

class Parent2
{
public:
    Parent2 ()
    {
        cout << " The Parent2 Class is called." << endl;
    }
};

class Child : public Parent2, public Parent1
{
public:
    Child ()
    {
        cout << " The Child Class is called." << endl;
    }
};

int main ()
{
    Child obj;

    return 0;
}
