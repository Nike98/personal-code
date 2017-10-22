///
/**
  * Implement the concept of Constructor and
  * Destructor with a suitable Example.
**/
///

#include <iostream>

using namespace std;

class Add
{
private:
    int a, b;
public:
    Add ()
    {
        cout << " Enter the value of a : ";
        cin >> a;
        cout << " Enter the value of b : ";
        cin >> b;
    }

    void Display ()
    {
        cout << "\n The Sum = " << a + b << endl;
    }

    ~Add ()
    {
        cout << "\n Destructor is being called ......" << endl;
    }
};

int main ()
{
    Add *obj;

    obj = new Add();
    obj -> Display();

    delete obj;

    return 0;
}
