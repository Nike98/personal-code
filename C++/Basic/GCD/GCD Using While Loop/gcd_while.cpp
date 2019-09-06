#include<iostream>
#include<conio.h>

using namespace std;

int main ()
{
    int n1, n2;

    cout << " Enter two numbers : " << endl;
    cin >> n1 >> n2;

    while (n1 != n2) {
        if (n1 > n2)
            n1 -= n2;
        else
            n2 -= n1;
    }

    cout << " HCF = " << n1;

    getch();
}
