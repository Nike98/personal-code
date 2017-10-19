#include <iostream>

using namespace std;

int main ()
{
    int arr[5], i;

    cout << " Enter the values : ";

    for (i = 1 ; i <= 5 ; i++){
        cin >> arr[i];
    }

    cout << " The values are : " << endl;

    for (i = 1 ; i <= 5 ; i++){
        cout << " " << arr[i] << endl;
    }

    return 0;
}
