///
/**
 *      WAP to Sort Elements of an Array
 */
///

#include<iostream>

using namespace std;

void Display(int size, int arr[size]);
void BubbleSort(int size, int arr[size]);

int main()
{
    // Get the Size of the Array
    int size;
    cout << " Enter the Size of the Array: ";
    cin >> size;

    int arr[size];

    cout << " Enter the " << size << " elements of the Array: " << endl;
    for (int i = 0; i < size; i++)
        cin >> arr[i];

    // Displaying the Array to the User before being sorted
    cout << "\n The Array before being Sorted is ..." << endl;
    Display(size, arr);

    // Calling the BubbleSort Method to perform Sorting
    BubbleSort(size, arr);
}

void BubbleSort(int size, int arr[size])
{
    for (int i = 0; i < (size - 1); i++){
        for (int j = 0; j < (size - i - 1); j++){
            // This logic is for doing it in Ascending order
            if (arr[j] > arr[j + 1]){
                int swap = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = swap;
            }
        }
    }

    cout << " The Array after being Sorted is ..." << endl;
    Display(size, arr);
}

void Display(int size, int arr[size])
{
    for (int i = 0; i < size; i++)
        cout << "  " << arr[i];
}
