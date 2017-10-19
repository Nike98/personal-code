#include <iostream>

using namespace std;

int main ()
{
    int row, col, line;
    char c = 'A';

    cout << " Enter the number of lines : ";
    cin >> line;
    cout << endl;

    for (row = line ; row >= 1 ; row--){
        for (col = 1 ; col <= row ; col++){
            cout << " " << c;
            c += 1;
        }

        cout << endl;
        c = 'A';
    }

    return 0;
}
