///
/**
  * WAP to illustrate Try - Catch
  * with Division by Zero "0"
**/
///

#include <iostream>

using namespace std;

int main ()
{
    int a, b;

    cout << " Enter the 1st value : ";
    cin >> a;
    cout << " Enter the 2nd value : ";
    cin >> b;

    try
    {
        if ( (a == 0) || (b == 0) ){
            throw "\n\n Exception : Division by Zero '0' not possible";
        }
        cout << "\n The Division = " << a / b << endl;
    }

    catch (const char* msg)
    {
        cerr << msg << endl;
    }

    return 0;
}
