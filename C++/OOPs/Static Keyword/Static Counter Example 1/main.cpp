#include<iostream>

using namespace std;

class Demo
{
    static int count;
public:
    void Increment();
};

int Demo :: count;

void Demo :: Increment()
{
    cout << " The value of count : " << count << endl;
    count++;
}

int main()
{
    Demo d1, d2, d3, d4, d5;

    d1.Increment();
    d2.Increment();
    d3.Increment();
    d4.Increment();
    d5.Increment();

    return 0;
}
