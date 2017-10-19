#include <iostream>
#include <conio.h>

using namespace std;

class fact
{
    int n, i, facti;
public:
    fact (int x)                 // copy constructor
    {
        n = x;
        facti = 1;
    }

    fact (fact &x)
    {
        n = x.n;
        facti = 1;
    }

    void calc()
    {
        for (i = 1 ; i <= n ; i++){
            facti *= i;
        }
    }

    void display()
    {
        cout << " \nFactorial : " << facti;
    }
};

int main ()
{
    int x;
    cout << " Enter the value : ";
    cin >> x;

    fact f1(x);
    f1.calc();                              // copy constructor called
    f1.display();

    fact f2(f1);
    f2.calc();                              // copy constructor takes an argument
    f2.display();

    getch();
}
