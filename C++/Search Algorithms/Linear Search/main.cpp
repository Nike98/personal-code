///
/**
 *      WAP to Search an elements in a User specified
 *      Array using Linear Search Algorithm.
 */
///

#include<iostream>
#include<stdlib.h>
#include<windows.h>

#define MAX 20

using namespace std;

void LinearSearch (int arr[], int size, int search_value)
{
    int index, flag;
    flag = 0;
    for (int i = 0; i < size; i++){
        if (arr[i] == search_value){
            index = i;
            flag = 1;
            break;
        }
    }

    (flag) ? cout << "\n The value " << search_value << " was found at position "
                  << index + 1 << " of the Array." << endl
           : cout << "\n The value " << search_value
                  << " does not exist in the Array." << endl;
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

        LinearSearch(arr, size, value);
    }

    return 0;
}
