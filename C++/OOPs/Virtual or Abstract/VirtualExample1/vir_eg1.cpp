#include <iostream>

using namespace std;

class A
{
private:
    int a;
public:
    void DisplayA ()
    {
        a = 10;
        cout << " Class A = " << a << endl;
    }
};

class B : public virtual a
{
    int b;
public:
    void DisplayB ()
    {
        b = 20;
        cout << " Class B = " << b << endl;
    }
};

class C : public virtual B
{
    int c;
public:
    coid DisplayC ()
    {
        c = 30;
        cout << " Class C = " << c << endl;
    }
};

class D : public B, public C
{
    int d;
public:
    void DisplayD ()
    {
        d = 40;
        cout << " Class D = " << d << endl;
    }
};

int main ()
{

}
