///
/**
  * WAP to check whether a number is Armstrong or not
**/
///

#include <iostream>

using namespace std;

int main ()
{
    int og_num, num, digit, sum = 0;

    cout << " Enter the Number : ";
    cin >> og_num;

    num = og_num;

    while ( num != 0 ){
        digit = num % 10;
        sum += digit * digit * digit;
        num /= 10;
    }

    if ( sum == og_num ){
        cout << "\n It is an Armstrong Number. " << endl;
    }

    else{
        cout << "\n It is Not an Armstrong Number. " << endl;
    }

    return 0;
}
