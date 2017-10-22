//
/*
 * WAP to show Main function can be friend
 * function of a class.
*/
//

#include <iostream>

using namespace std;

class A
{
private:
    int a = 10, b = 20;
public:
    friend int main ();
};

int main ()
{
    A obj;

    cout << " The Sum = " << obj.a + obj.b << endl;

    return 0;
}
