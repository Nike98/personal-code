///
/**
  *##############################################
  *
  *     WAP to print the following pattern
  *            (using constructor)
  *
  *                 $
  *                 $$
  *                 $$$
  *                 $$$$
  *                 $$$$$
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

class Pattern
{
private:
    int row, col, lines;
public:
    Pattern ()
    {
        cout << " Enter the number of Lines : ";
        cin >> lines;
        cout << endl;

        for ( row = 1 ; row <= lines ; row++ ){
            for ( col = 1 ; col <= row ; col++ ){
                cout << " $";
            }
            cout << endl;
        }
    }
};

int main ()
{
    Pattern obj;

    return 0;
}
