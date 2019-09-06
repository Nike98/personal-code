#include<iostream>

using namespace std;

int main ()
{
    int k, m, n;

    cout << " Enter the digit = ";
    cin >> m;
    cout << "\n";

    for (n = 1 ; n <= 10 ; n++)
    {
        k = m * n;

        cout << " " << m << " x" << " " << n << " =" << " " << k << endl;
    }

    return 0;
}
