#include<iostream>

using namespace std;

int factorial(int num);

int main()
{
    int num;

    cout << " Enter the Number: ";
    cin >> num;

    cout << "\n Factorial of the Number is : " << factorial(num) << endl;

    return 0;
}

int factorial(int num)
{
    if (num > 1)
        return num * factorial(num - 1);
    else
        return 1;
}
