///
/**
 *      WAP to implement the concept of Hybrid Inheritance
 */
///

#include<iostream>

using namespace std;

int a,b,c,d,e;

class A
{
public:
    void getAB()
    {
        cout << " Enter the value of A : ";
        cin >> a;
        cout << " Enter the value of B : ";
        cin >> b;
    }
};

class B : public A
{
public:
    void getC()
    {
        cout << " Enter the value of C : ";
        cin >> c;
    }
};

class C
{
public:
    void getD()
    {
        cout << " Enter the value of D : ";
        cin >> d;
    }
};

class D : public B, public C
{
public:
    void result()
    {
        getAB();
        getC();
        getD();

        e = a + b + c + d;

        cout << "\n\n The Addition is : " << e << endl;
    }
};

int main()
{
    D d1;
    d1.result();

    return 0;
}
