///
/**
 *      WAP to implement Radix Sort on an Array
 */
///

#include<iostream>
#include<stdlib.h>

using namespace std;

int getMax(int arr[], int size)
{
    int max = arr[0];

    for (int i = 1; i < size; i++){
        if (arr[i] > max)
            max = arr[0];
    }
    return max;
}

void countSort(int arr[], int size, int exp)
{
    int output[size];
    int count[10] = {0};

    for(int i = 0; i < size; i++)
        count[(arr[i]/exp) % 10]++;

    for (int i = 1; i < 10; i++)
        count[i] += count[i-1];

    for (int i = size - 1; i >= 0; i--){
        output[count[(arr[i]/exp) % 10] - 1] = arr[i];
        count[(arr[i]/exp) % 10]--;
    }

    for (int i = 0; i < size; i++)
        arr[i] = output[i];
}

void radixSort(int arr[], int size)
{
    int max = getMax(arr, size);

    for (int exp = 1; max/exp > 0; exp *= 10)
        countSort(arr, size, exp);
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

    // Passing the Array to the Quick Sort method
    radixSort(arr, size);

    // Printing the Array after Sorting it
    cout << "\n Array after being Sorted...\n";
    printArray(arr, size);

    return 0;
}







































