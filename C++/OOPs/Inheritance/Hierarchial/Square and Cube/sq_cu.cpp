#include <iostream>

using namespace std;

class A
{
protected:
    int no;
public:
    void GetNo ()
    {
        cout << "\n Enter the Number : ";
        cin >> no;
    }
};

class B : public A
{
public:
    void Square ()
    {
        cout << " Square Unit No : " << no * no << endl;
    }
};

class C : public A
{
public:
    void Cube ()
    {
        cout << " Cube of the Number = " << no * no * no << endl;
    }
};

int main ()
{
    B objb;
    C objc;

    objb.GetNo();
    objb.Square();

    objc.GetNo();
    objc.Cube();

    return 0;
}
