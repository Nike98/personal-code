#include <iostream>

using namespace std;

int main()
{
    int num, i, rem, sum = 0, num_copy;
    cout << " Enter the Number: ";
    cin >> num;

    num_copy = num;

    for (int i = 1; i < num_copy; i++){
        rem = num_copy % i;
        if (rem == 0)
            sum += i;
    }

    if (sum == num)
        cout << "\n It is a Perfect Number." << endl;
    else
        cout << "\n It is Not a Perfect Number." << endl;

    return 0;
}
