#include<iostream>
#include<conio.h>

using namespace std;

int main ()
{
    int og_num, num, digit, sum = 0;

    cout << " Enter a positive integer = ";
    cin >> og_num;
    cout << " \n\n";

    num = og_num;

    while (num != 0){
        digit = num % 10;
        sum += digit * digit * digit;
        num /= 10;
    }

    if (sum == og_num){
        cout << " " << og_num << " is an Armstrong number" << endl;
    }

    else{
        cout << " " << og_num << " is not an Armstrong number" << endl;
    }

    getch();
}
