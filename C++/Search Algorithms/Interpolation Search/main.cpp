///
/**
 *      WAP to perform Interpolation Search on a user defined Array.
 */
///

#include<iostream>
#include<stdlib.h>

#define MAX 20

using namespace std;

int InterpolationSearch(int arr[], int size, int value)
{
    int low = 0, high = (size - 1);

    while (low <= high && value >= arr[low] && value <= arr[high]){
        if (low == high){
            if (arr[low] == value)
                return low;
            return -1;
        }

        int pos = low + (((high - low) / (arr[high] - arr[low])) * (value - arr[low]));

        if (arr[pos] == value)
            return pos;

        if (arr[pos] < value)
            low = pos + 1;

        else
            high = pos - 1;
    }
    return -1;
}

int main()
{
    int size, value;
    cout << " Enter the size of the Array : ";
    cin >> size;

    if (size > MAX){
        cout << "\n The Array size exceeds the available size." << endl;
        exit(0);
    }
    else{
        int arr[size];      // Initializing the Array with the size specified by the User

        cout << "\n\n Enter the " << size << " elements of the Array...\n";
        for (int i = 0; i < size; i++)
            cin >> arr[i];

        system("cls");

        cout << "\n\n Enter the value to be Searched within the Array: ";
        cin >> value;

        int search_result = InterpolationSearch(arr, size, value);

        (search_result != -1) ? cout << "\n\n The value " << value << " found at position "
                                     << search_result+1 << " of the Array." << endl
                              : cout << "\n\n Specified element is not present in the Array." << endl;
    }

    return 0;
}
