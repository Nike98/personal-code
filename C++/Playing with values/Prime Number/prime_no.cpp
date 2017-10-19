#include<iostream>
#include<conio.h>

using namespace std;

int main()
{
    int n, i, f = 0;

    cout << " Enter the number : ";
    cin >> n;
    cout << "\n\n";

    for (i = 2 ; i <= n / 2 ; i++){
        if (n % i == 0){
            f = 1;
            break;
        }
    }

    if (f == 0){
        cout << " This is a Prime Number" << endl;
    }
    else{
        cout << " This is not a Prime Number" << endl;
    }

    getch();
}
