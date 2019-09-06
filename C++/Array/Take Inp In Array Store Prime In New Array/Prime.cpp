#include <iostream>

using namespace std;

int main ()
{
    int arr[20], prime_arr[20], size, i, j, count, prime_size = 0;

    cout << " Enter the Size of the Array : ";
    cin >> size;
    cout << endl;

    cout << " Enter the Values of the Array : " << endl;

    for ( i = 0 ; i < size ; i++ ){
        cin >> arr[i];
    }

    for ( i = 0 ; i < size ; i++ ){
            count = 0;
       for ( j = 1 ; j < arr[i] ; j++ ) {
        if ( arr[i] % j == 0 ){
           count += 1;
        }
       }
    if ( count = 2 ){
        prime_arr[prime_size] = arr[i];
        prime_size += 1;
    }
    }

    for ( i = 0 ; i < prime_size ; i++ ){
        cout << " " << prime_arr[i] << endl;
    }

    return 0;
}
