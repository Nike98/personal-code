// Sum of all Even and Odd Numbers in an Array

#include <iostream>

using namespace std;

int main()
{
    int arr_size;

    // Taking input of the Size from the User
    cout << " Enter the size of the Array: ";
    cin >> arr_size;

    // Initializing Array with Size
    int arr[arr_size], count_even = 0, count_odd = 0;

    cout << "\n Enter the " << arr_size << " Elements...\n\n" ;
    for (int i = 0; i < arr_size; i++)
        cin >> arr[i];

    for (int i = 0; i < arr_size; i++){
        if (arr[i] % 2 == 0)
            count_even++;
        else
            count_odd++;
    }

    cout << "\n The Count of all the Even Numbers in the Array is: " << count_even << endl;
    cout << "\n The Count of all the Odd Numbers in the Array is: " << count_odd << endl;

    return 0;
}
