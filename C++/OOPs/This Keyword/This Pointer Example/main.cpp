///
/**
 *      WAP to demonstrate use of this pointer.
 */
///

#include<iostream>

using namespace std;

class Demo
{
private:
    int a,b;

public:
    void Input(int a, int b)
    {
        this->a = a+b;
        this->b = a-b;
    }

    void Output()
    {
        cout << " a : " << a << endl;
        cout << " b : " << b << endl;
    }
};

int main()
{
    Demo obj;
    obj.Input(7, 3);
    obj.Output();

    return 0;
}

































