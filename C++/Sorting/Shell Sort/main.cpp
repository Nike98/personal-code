///
/**
 *      WAP to Sort an Array using Shell Sort Algorithm
 */
///

#include<iostream>
#include<windows.h>

using namespace std;

int ShellSort(int arr[], int size)
{
    for (int gap = size/2; gap > 0; gap /=2){
        for (int i = gap; i < size; i++){
            int temp = arr[i];
            int j;
            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                arr[j] = arr[j - gap];
            arr[j] = temp;
        }
    }
    return 0;
}

void printArray(int arr[], int size)
{
    for (int i = 0; i < size; i++)
        cout << "  " << arr[i];
    cout << "\n";
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

    // Passing the Array to the Shell Sort method
    ShellSort(arr, size);

    // Printing the Array after Sorting it
    cout << "\n Array after being Sorted...\n";
    printArray(arr, size);

    return 0;
}
