///
/**
 *      WAP to Display a Menu to the User consisting of
 *      two options, Linear and Binary as in Searching
 *      algorithms and perform the element search
 *      according to the selected algorithm.
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

        /*(arr[mid] > search_value) ? return BinarySearch(arr, start, mid-1, search_value)
                                  : return BinarySearch(arr, mid+1, end, search_value);*/
        /// Tried using the above statement to perform recursion
        /// but it seems that it doesn't work as directly the
        /// return statement is used instead of logic or strings statements

        if (arr[mid] > search_value)
            return BinarySearch(arr, start, mid-1, search_value);
        else
            return BinarySearch(arr, mid+1, end, search_value);
    }

    return -1;
}

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

    // Shift this to another function
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

        int choice;

        cout << "\n\n Enter the value to be Searched within the Array: ";
        cin >> value;

        cout << "\n\n ##### SEARCHING ALGORITHMS AVAILABLE #####\n\n";
        cout << "1. Linear Search\n"
             << "2. Binary Search\n"
             << "3. EXIT\n\n";
        cout << " Enter your choice: ";
        cin >> choice;

        switch(choice){
        case 1:
            LinearSearch(arr, size, value);
            break;
        case 2:{
            int search_result = BinarySearch(arr, 0, size, value);

            (search_result == -1) ? cout << "\n\n Specified element is not present in the Array." << endl
                                  : cout << "\n\n The value " << value << " found at position "
                                         << search_result+1 << " of the Array." << endl;

            // make a separate function for it.
            break;
        }
        case 3:{
            cout << "\n\n Goodbye!" << endl;
            exit(0);
            break;
        }
        }


    }

    return 0;
}
