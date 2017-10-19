#include<iostream>

using namespace std;

int main()
{
    int row, space, col, n;

    cout << " Enter the number of lines : ";
    cin >> n;
    cout << "\n\n";

    for (row = 1 ; row <= n ; row++){
        for (space = 1 ; space <= n-row ; space++){
            cout << " ";
        }
        for (col = 1 ; col <= row ; col++){
            cout << col;
        }
        cout << endl;
    }
}
