#include <iostream>
#include <string.h>

using namespace std;

class Test
{
private:
    string *x;
public:
    Test (string x){
        this -> x = new string (x);
        cout << "\n My name is " << x << endl;
    }

    Test(const Test &p){
        cout << "\n The Copy Constructor is called..." << endl;

        x = new string (*p.x);

        cout << "\n The String in x is " << *x << endl;
    }
};

int main ()
{
    Test t("Nikhil");

    Test t1(t);

    return 0;
}
