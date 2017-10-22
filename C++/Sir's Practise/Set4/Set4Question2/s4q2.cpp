//
/*
 * WAP to compare 2 Strings lengthwise
*/
//

#include <iostream>
#include <stdio.h>
#include <string.h>

using namespace std;

int main ()
{
    char str1[50], str2[50];
    int chk1, chk2;

    cout << " Enter the 1st String : ";
    cin >> str1;
    //gets(str1);

    cout << " Enter the 2nd String : ";
    cin >> str2;
    //gets(str2);

    chk1 = strlen(str1);
    chk2 = strlen(str2);

    if ( chk1 = chk2 ){
        cout << " Both the Strings are Equal in Length" << endl;
    }

    else{
        cout << " Both the Strings are Not Equal in Length" << endl;
    }

    return 0;
}
