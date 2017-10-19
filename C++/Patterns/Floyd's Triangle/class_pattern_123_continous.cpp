#include<iostream>

using namespace std;

class patt
{
public:
    patt()
    {
        int num=1, i, j, row;

        cout << " Enter the number of rows : ";
        cin >> row;
        cout << "\n";

        for(i = 1 ; i <= row ; i++){
            for(j = 1 ; j <= i ; j++){
                cout << " " << num;
                num++;
            }
            cout << endl;
        }
    }
};

int main ()
{
    patt obj;

    return 0;
}
