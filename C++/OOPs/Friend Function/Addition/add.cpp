#include <iostream>

using namespace std;

class A
{
private:
    int a;
public:
    A (){
        cout << " Enter the value of a : ";
        cin >> a;
    }

    friend class B;                              // Friend Class declared
};

class B                                             // Friend Class defined
{
private:
    int b;
public:
    B (){
        cout << "\n Enter the value of b : ";
        cin >> b;
    }

    void Display ( A &x ){
        cout << "\n The Addition of a & b = " << x.a + b << endl;
    }
};

int main ()
{
    A obja;
    B objb;

    objb.Display(obja);

    return 0;
}
