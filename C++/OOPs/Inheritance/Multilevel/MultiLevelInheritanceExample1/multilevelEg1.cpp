#include <iostream>

using namespace std;

class Child1
{
public:
    void Display ()
    {
        cout << " The Class Child1 is called." << endl;
    }
};

class Child2 : public Child1
{

};

class Parent : public Child2
{

};

int main ()
{
    Parent obj;

    obj.Display();

    return 0;
}
