#include <iostream>

using namespace std;

class Dollar
{
private:
    char d = '$';
public:
    Dollar ()                                           // Default Constructor being defined here
    {
        int i, j, n;
        char sign;
        sign = d;

        cout << " Enter the number of lines : ";
        cin >> n;
        cout << "\n";

        for (i = 1 ; i <= n ; i++){
                for (j = 1 ; j <= i ; j++){
                    cout << " " << d;
                }
                cout << "\n";
        }
    }
};

int main ()
{
    Dollar print;                                       // Default Constructor being called here

    return 0;
}
