///
/**
  *##############################################
  *
  *       WAP that will print Armstrong
  *           Number using function
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

int ArmstrongNumber(int a)
{
    int num, digit, sum = 0;

    num = a;

    while (num != 0){
        digit = num % 10;
        sum += digit * digit * digit;
        num /= 10;
    }

    return sum;
}

int main ()
{
    int og_num, res;

    cout << " Enter the Number : ";
    cin >> og_num;

    res = ArmstrongNumber(og_num);

    if (res == og_num){
        cout << "\n It is an Armstrong Number" << endl;
    }

    else{
        cout << "\n It is Not an Armstrong Number" << endl;
    }

    return 0;
}
