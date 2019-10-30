///
/**
 *      Write a program to calculate the length of a string
 *      entered by the user without using any standard library
 *      string handling function
 */
///


#include<iostream>
#include<string>

using namespace std;

int main()
{
    string str;
    int count = 0;

    cout << " Enter the String : ";
    getline(cin, str);

    for (int i = 0; str[i] != '\0'; i++)
        count++;

    cout << "\n\n The Calculated Length of the String is : " << count << endl;

    return 0;
}
