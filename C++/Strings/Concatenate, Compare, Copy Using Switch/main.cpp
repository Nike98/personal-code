///
/**
 *      WAP to Concatenate, Compare and Copy two Strings
 *      using Switch Case.
 */
///

#include<iostream>
#include<cstring>

using namespace std;

int main ()
{
    int choice = 0;
    char str1[15], str2[15];

    cout << "\n\n Enter the 1st String : ";
    cin.getline(str1, 15);

    cout << "\n Enter the 2nd String : ";
    cin.getline(str2, 15);

    do {

        cout << "\n\n 1. CONCATENATION" << endl;
        cout << " 2. COMPARE" << endl;
        cout << " 3. COPY" << endl;
        cout << " 4. EXIT" << endl;
        cout << "\n Enter your choice : ";
        cin >> choice;

        switch(choice){
        case 1:
            cout << "\n\n The Concatenation is : " << strcat(str1, str2) << endl;
            break;
        case 2:{
            int i = strcmp(str1, str2);
            if (i == 0)
                cout << "\n\n Both the Strings are Equal." << endl;
            else
                cout << "\n\n The Strings are Not Equal." << endl;
            break;
        }
        case 3:
            cout << "\n\n The Copied String : " << strcpy(str1, str2) << endl;
            break;
        }
    } while (choice < 4);

    return 0;
}
