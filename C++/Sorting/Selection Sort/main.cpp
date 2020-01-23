///
/**
 *      WAP to sort an Array using Selection Sort algorithm.
 */
///

#include<iostream>

using namespace std;

void swap(int *x, int *p)
{
    int temp = *x;
    *x = *p;
    *p = temp;
}

void SelectionSort(int arr[], int n)
{
    for (int i = 0; i < n; i++){
        int min_index = i;
        for (int j = i+1; j < n; j++){
            if (arr[j] < arr[min_index])
                min_index = j;
        }
        swap(arr[min_index], arr[i]);
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

    int arr[size];

    cout << "\n Enter all the Array Elements...\n";
    for (int i = 0; i < size; i++)
        cin >> arr[i];

    // Printing the Array before Sorting
    cout << "\n The Array before being Sorted...\n";
    printArray(arr, size);

    // Passing the Array to the Selection Sort method
    SelectionSort(arr, size);

    // Printing the Array after Sorting it
    cout << "\n Array after being Sorted...\n";
    printArray(arr, size);

    return 0;
}
