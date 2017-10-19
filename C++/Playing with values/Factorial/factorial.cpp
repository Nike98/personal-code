#include<iostream>
#include<conio.h>

using namespace std;

int main ()
{
    int i, n;
    unsigned long long int f = 1;

    cout << " Enter the digit = ";
    cin >> n;
    cout << "\n";

    for (i = 1 ; i <= n ; i++){
        f *= i;
    }

    cout << " The factorial = " << f << endl;

    getch();
}
