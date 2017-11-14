///
/**
  *##############################################
  *
  *      WAP to calculate Fibonacci Series
  *                 of a number
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

int main ()
{
    int num, first, second, sum = 0, i;
    first = 0, second = 1;

    cout << " Enter the number = ";
    cin >> num;
    cout << "\n\n";

    for(i = 1 ; i <= num ; i++){
        cout << " " << first << endl;
        sum = first + second;
        first = second;
        second = sum;
    }

    return 0;
}
