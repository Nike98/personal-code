#include <iostream>
#include <conio.h>

using namespace std;

inline int check(int a, int b, int c)
{
    return a > b ? (a > c ? a : c) : (b > c ? b : c);
}

int main ()
{
    int num, inp1, inp2, inp3;
    cout << " Enter the 1st value : ";
    cin >> inp1;
    cout << " Enter the 2nd value : ";
    cin >> inp2;
    cout << " Enter the 3rd value : ";
    cin >> inp3;

    num = check(inp1, inp2, inp3);

    cout << " The Biggest value : " << num << endl;

    getch();
}
