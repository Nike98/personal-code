///
/**
  *##############################################
  *
  *     WAP to print the following pattern :
  *
  *                   1
  *                  12
  *                 123
  *                1234
  *               12345
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

int main ()
{
    int num = 1, row, col, space, lines;

    cout << " Enter the Number of Lines : ";
    cin >> lines;

    for ( row = 1 ; row <= lines ; row++ ){
        for ( space = 1 ; space <= lines-row ; space++ ){
                cout << " ";
        }
        for ( col = 1 ; col <= row ; col++ ){
            cout << "" << num;
            num += 1;
        }
        cout << endl;
        num = 1;
    }

    return 0;
}
