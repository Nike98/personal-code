#include<iostream>

using namespace std;

class A
{
public:
    int a;
    void get()
    {
        cout << " Enter any number : ";
        cin >> a;
        cout << "\n";
    }

    A operator == (const A & c)
    {
        A b;
        if(a == c.a){
            cout << " is Equal" << endl;
        }
        else{
            cout << " is not Equal" << endl;
        }
    }

public:
    void Display()
    {
        cout << a << endl;
    }
};

int main ()
{
    A x, y;
    x.get();
    y.get();
    x == y;
}
