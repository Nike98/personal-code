#include <iostream>

using namespace std;

class A
{
protected:
    int x = 10;
public:
    void Display ()
    {
        cout << " x = " << x << endl;
    }
};

class B
{
protected:
    int y = 20;
public:
    void Display ()
    {
        cout << " y = " << y << endl;
    }
};

class P : public A, public B
{
protected:
    int sum;
public:
    void Add()
    {
        sum = x + y;
        cout << " The Sum = " << sum << endl;
    }
};

int main ()
{
    P num;

    num.A :: Display ();
    num.Add ();

    return 0;
}
