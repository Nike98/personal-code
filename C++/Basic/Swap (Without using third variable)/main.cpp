// Swapping Without Using third variable

#include <iostream>

using namespace std;

int main()
{
    int val1, val2;

    cout << " Enter the 1st value: ";
    cin >> val1;

    cout << "\n Enter the 2nd value: ";
    cin >> val2;

    val1 += val2;
    val2 = val1 - val2;
    val1 -= val2;

    cout << "\n The values after being Swapped are: " << endl;
    cout << " 1st value : " << val1 << endl;
    cout << " 2nd value : " << val2 << endl;
    return 0;
}
