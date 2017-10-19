#include<iostream>

using namespace std;

int main ()
{
    int arr[50], size, i, sum = 0;

    cout << " Enter the size of the Array = ";
    cin >> size;
    cout << " \n\n";

    for (i = 1 ; i <= size ; i++){
        cout << " Enter the value = ";
        cin >> arr[i];
        sum += arr[i];
        cout << "\n";
    }

    cout << " The sum of the Array = " << sum << endl;
    return 0;
}
