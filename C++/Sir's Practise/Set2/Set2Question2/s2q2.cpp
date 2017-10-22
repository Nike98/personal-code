//
/*
 * WAP to input a String From the User
 * Check whether the string is Palindrome or not
*/
//

#include <iostream>
#include <string.h>

using namespace std;

int main ()
{
    char strInp[50], strChk[50];
    int i, len, flag = 0;

    cout << " Enter the String : ";
    cin >> strInp;

    len = strlen(strInp);

    for ( i = 0 ; i < len ; i++ ){
        if ( strInp[i] != strInp[len - i - 1]){
            flag = 1;
        }
    }

    if (flag){
        cout << "\n The String " << strInp << " is a Not Palindrome String." << endl;
    }

    else{
        cout << "\n The String " << strInp << " is a Palindrome String." << endl;
    }

    return 0;
}
