///
/**
 *      WAP to sort an Array using the Insertion Sort algorithm.
 */
///

#include<iostream>
#include<stdlib.h>

using namespace std;

void InsertionSort(int arr[], int n)
{
    for (int i = 1; i < n; i++){
        int key = arr[i];
        int j = i - 1;

        while ((j > -1) && (arr[j] > key)){
            arr[j+1] = arr[j];
            j--;
        }
        arr[j+1] = key;
    }
}

void printArray(int arr[], int size)
{
    for (int i = 0; i < size; i++)
        cout << " " << arr[i];
    cout << endl;
}

int main()
{
    int size;

    cout << " Enter the size of the Array : ";
    cin >> size;
    system("cls");

    int arr[size];

    cout << "\n Enter all the Array Elements...\n";
    for (int i = 0; i < size; i++)
        cin >> arr[i];
    system("cls");

    // Printing the Array before Sorting
    cout << "\n The Array before being Sorted...\n";
    printArray(arr, size);

    // Passing the Array to the Insertion Sort method
    InsertionSort(arr, size);

    // Printing the Array after Sorting it
    cout << "\n Array after being Sorted...\n";
    printArray(arr, size);

    return 0;
}
