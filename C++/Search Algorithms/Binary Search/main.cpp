///
/**
 *      WAP to search an element in a user defined Array
 *      using Binary Search algorithm.
 */
///

#include<iostream>
#include<stdlib.h>
#include<windows.h>

#define MAX 20

using namespace std;

int BinarySearch(int arr[], int start, int end, int search_value)
{
    if (end >= start){
        int mid = (start + end) / 2;

        if (arr[mid] == search_value)
            return mid;

        if (arr[mid] > search_value)
            return BinarySearch(arr, start, mid-1, search_value);
        else
            return BinarySearch(arr, mid+1, end, search_value);
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

        int search_result = BinarySearch(arr, 0, size, value);

        (search_result == -1) ? cout << "\n\n Specified element is not present in the Array." << endl
                              : cout << "\n\n The value " << value << " found at position " <<
                                        search_result+1 << " of the Array." << endl;
    }

    return 0;
}
