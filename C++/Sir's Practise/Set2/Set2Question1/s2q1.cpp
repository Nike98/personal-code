//
/*
 * WAP to Illustrate Inline Function
 * that return the max of 3 numbers.
*/
//

#include <iostream>

using namespace std;

inline int Calc ( int a, int b, int c )
{
    return a > b ? ( a > c ? a : c ) : ( b > c ? b : c );
}

int main ()
{
    int inp1, inp2, inp3, maxVal;

    cout << " Enter the 1st value : ";
    cin >> inp1;
    cout << " Enter the 2nd value : ";
    cin >> inp2;
    cout << " Enter the 3rd value : ";
    cin >> inp3;

    maxVal = Calc ( inp1, inp2, inp3 );

    cout << "\n\n The Maximum value of the 3 values is = " << maxVal << endl;

    return 0;
}
