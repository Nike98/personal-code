#include <iostream>
#include <conio.h>

using namespace std;

inline calc (int a, float b, int c)
{
    return a*b*c/100;
}

int main ()
{
    int price, time;
    float rate, si;

    cout << " Enter the Price : ";
    cin >> price;
    cout << " Enter the Rate of Interest : ";
    cin >> rate;
    cout << " Enter the Time Period : ";
    cin >> time;

    si = calc (price, rate, time);

    cout << " The Simple Interest : " << si << endl;

    getch();
}
