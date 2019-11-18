///
/**
 *      WAP to read two integers from the keyboard and to perform
 *      simple arithmetic operations using the pointer technique.
 *      The memory space for the variables is allocated by the new operator.
 */
///

#include<iostream>

using namespace std;

int main()
{
    int sum = 0, n = 2;
    int *a = new int[n];

    cout << " Enter " << n << " integer numbers...\n" << endl;

    for (int i = 0; i < n; i++)
        cin >> a[i];

    for (int i = 0; i < n; i++)
        sum += a[i];

    cout << "\n\n Total Sum : " << sum << endl;
    delete(a);

    return 0;
}
