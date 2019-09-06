// Multiplication of 2 Matrices

#include <iostream>

using namespace std;

void multiply(int row, int col, int arr1[row][col], int arr2[row][col]);
void display(int row, int col, int arr[row][col]);

int main()
{
    int row, col;
    cout << " Enter the Row Size of the Matrix: ";
    cin >> row;
    cout << "\n Enter the Column Size of the Matrix: ";
    cin >> col;

    int arr1[row][col], arr2[row][col];

    // Input for the 1st Array
    cout << "\n Enter the Values for the 1st Array:" << endl;
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            cin >> arr1[i][j];
        }
    }

    // Input for the 2nd Array
    cout << "\n Enter the Values for the 2nd Array:" << endl;
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            cin >> arr2[i][j];
        }
    }

    // Displaying Both the Arrays
    display(row, col, arr1);
    display(row, col, arr2);

    return 0;
}

void multiply(int row, int col, int arr1[row][col], int arr2[row][col])
{
    int mul[row][col]l;
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            mul[row][col] = arr1[row][col] * arr2[row][col];
        }
        cout << endl;
    }
    display(row, col, mul);
}

void display(int row, int col, int arr[row][col])
{
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            cout << " " << arr[i][j];
        }
        cout << endl;
    }
}
