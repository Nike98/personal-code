///
/**
  * WAP to Sort an Array in Descending Order
  * using Class
**/
///

#include <iostream>

using namespace std;

class DescendingSort
{
private:
    int arr[50], num, i, j, temp;
public:
    DescendingSort ()
    {
        cout << " Enter the Number of Elements : ";
        cin >> num;
        cout << endl << endl;

        for ( i = 1 ; i <= num ; i++ ){
            cout << " Enter the Value of " << i << " value : ";
            cin >> arr[i];
        }

        for ( i = 1 ; i <= num ; i++ ){
            for ( j = i + 1 ; j <= num ; j++ ){
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    void Display ()
    {
        cout << "\n\n The Sorted Array in Descending Order : " << endl;
        for ( i = 1 ; i <= num ; i++ ){
            cout << " " << arr[i] << endl;
        }
    }
};

int main ()
{
    DescendingSort obj;

    obj.Display();

    return 0;
}
