///
/**
 *      Declare an integer array with 5 members and print them using pointer notation.
 */
///

#include<iostream>

using namespace std;

int main()
{
    int arr[5] = {8,6,9,4,3};
    int *p = arr;

    for (int i = 0; i < 5; i++){
        cout << " " << *p;
        p++;
    }
    cout << "\n";

    return 0;
}
