#include<iostream>

using namespace std;

int main ()
{
    int arr[50], big, small, size, i;
    big = small = 0;

    cout << " Enter the size of the Array = ";
    cin >> size;
    cout << "\n\n";

    for(i = 1 ; i <= size ; i++){
        cout << " Enter the value = ";
        cin >> arr[i];
        cout << "\n";
    }

    big = arr[1];
    small = arr[1];

    for(i = 1 ; i <= size ; i++){
        if(arr[i] > big){
            big = arr[i];
        }
        if(arr[i] < small){
            small = arr[i];
        }
    }

    cout << " The Biggest value = " << big << endl;
    cout << " the Smallest value = " << small << endl;

    return 0;
}
