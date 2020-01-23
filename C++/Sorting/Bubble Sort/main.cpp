///
/**
 *      WAP to Sort Elements Using Bubble Sort method
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

//  Function to perform Bubble Sort on the Array
void bubbleSort(int arr[], int n)
{
    for (int i = 0; i < n-1; i++){
        for (int j = 0; j < n-i-1; j++){
            if (arr[j] > arr[j+1])
                swap(&arr[j], &arr[j+1]);
        }
    }
}

//  Function to Print the Array
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

    // Passing the Array to the Bubble Sort method
    bubbleSort(arr, size);

    // Printing the Array after Sorting it
    cout << "\n Array after being Sorted...\n";
    printArray(arr, size);

    return 0;
}
