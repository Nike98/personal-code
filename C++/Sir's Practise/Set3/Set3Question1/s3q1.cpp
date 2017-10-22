//
/*
 * WAP to print Floyd's Triangle
 * using Constructor
 *
 * Floyd Triangle :
 * 1
 * 2 3
 * 4 5 6
 * 7 8 9 10
 * and so on ....
*/
//

#include <iostream>

using namespace std;

class FloydTriangle
{
private:
    int num = 1;
public:
    FloydTriangle ()
    {
        int row, col, line;

        cout << " Enter the number of lines : ";
        cin >> line;

        for ( row = 1 ; row <= line ; row++ ){
            for ( col = 1 ; col <= row ; col++ ){
                cout << " " << num;
                num++;
            }

            cout << endl;
        }
    }
};

int main ()
{
    FloydTriangle obj;

    return 0;
}
