#include<iostream>
#include<conio.h>

using namespace std;

int main ()
{
    int num, val, temp, rev = 0;

    cout << " Enter the value : ";
    cin >> val;
    cout << "\n\n";

    num = val;

    while (num != 0){
        temp =  num % 10;
        rev = (rev * 10) + temp;
        num /= 10;
    }

    cout << "\n The Reverse Number is : " << rev << endl;

    return 0;
}

