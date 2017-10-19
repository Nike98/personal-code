#include<iostream>
#include<string.h>

using namespace std;

int main()
{
    int a;
    char str1[100], str2[100];

    cout << " Enter the 1st string : ";
    cin >> str1;
    cout << "\n\n";

    cout << " Enter the 2nd string : ";
    cin >> str2;

    a = strcmp (str1, str2);

    if(a == 0){
        cout << " Both the strings are equal" << endl;
    }

    else{
        cout << " \n\nBoth the strings are not equal" << endl;
    }

    return 0;
}
