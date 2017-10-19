#include<iostream>
#include<conio.h>

using namespace std;

class Check
{
private:
    int i;
public:
    Check(): i(0) {  }
    void operator ++()
    {
        ++i;
    }
    void display()
    {
        cout << " i = " << i << endl;
    }
};

int main ()
{
    Check obj;
    obj.display();
    ++obj;
    obj.display();
    getch();
}
