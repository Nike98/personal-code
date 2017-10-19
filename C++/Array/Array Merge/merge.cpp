#include<iostream>

using namespace std;

int main()
{
    int arr1[50], arr2[50], size, size1, size2, i, j, k, merge[100];

    cout << " ************* Enter the elemnts of Array 1 : ";
    cin >> size1;
    cout << "\n\n";

    for (i = 0 ; i < size1 ; i++){
        cout << " The value of " << i << " element : ";
        cin >> arr1[i];
        cout << "\n";
    }

    cout << " \n\n";
    cout << " ************* Enter the elemnts of Array 2 : ";
    cin >> size2;
    cout << "\n\n";

    for (i = 0 ; i < size2 ; i++){
        cout << " The value of " << i << " element : ";
        cin >> arr2[i];
        cout << "\n";
    }

    for (i = 0 ; i < size1 ; i++){
        merge[i] = arr1[i];
    }

    size = size1 + size2;

    for (i = 0 , k = size1 ; k < size  &&  i < size2 ; i++ , k++){
        merge[k] = arr2[i];
    }

    cout << " ************* Now the Array after Merging is : *************" << "\n\n";

    for (i = 0 ; i < size ; i++){
        cout << " " << merge[i] << " " << endl;
    }

    return 0;
}
