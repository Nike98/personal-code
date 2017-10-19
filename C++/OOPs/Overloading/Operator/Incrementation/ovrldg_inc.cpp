#include<iostream>

using namespace std;

class check
{
private:
    int i;
public:
    check(): i(0) {  }

    check operator ++()
    {
        check temp;
        ++i;
        temp.i = i;

        return temp;
    }

    void display()
    {
        cout << " i = " << i << endl;
    }
};

int main ()
{
    check obj, obj1;
    obj.display();
    obj1.display();

    obj1 = ++obj;

    obj.display();
    obj1.display();

    return 0;
}
