#include<iostream>

using namespace std;

int main()
{
    int rev = 0, num = 0, rem;

    cout << "Enter a number: ";
    cin >> num;

    int n = num;

    for( ; num != 0; num /= 10){
        rem = num % 10;
        rev = rev * 10 + rem;
    }
    for( ; rev != 0; rev /= 10){
        rem = rev % 10;
        if(rem == 1)
            cout << "One";
        else if(rem == 2)
            cout << "Two";
        else if(rem == 3)
            cout << "Three";
        else if(rem == 4)
            cout << "Four";
        else if(rem == 5)
            cout << "Five";
        else if(rem == 6)
            cout << "Six";
        else if(rem == 7)
            cout << "Seven";
        else if(rem == 8)
            cout << "Eight";
        else if(rem == 9)
            cout << "Nine";
        else
            cout << "Zero";
    }
}
