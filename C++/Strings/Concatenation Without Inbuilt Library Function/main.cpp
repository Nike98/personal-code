///
/**
 *      Write a program to implement a function concat(char a[],
 *      char b[], char c[], int max) that concatenates the strings
 *      ‘a’ and ‘b’ to the string ‘c’, ‘max’ is the maximum size of the
 *      concatenated string. Without using any standard library string handling functions.
 */
///

#include<iostream>

using namespace std;

void concat(char a[], char b[], char c[], int max)
{
    int index1 = 0;
    int index2 = 0;

    while (a[index1] != '\0'){
        c[index1] = a[index1];
        index1++;
    }

    while (b[index2] != '\0'){
            index1++;
        c[index1] = b[index2];
        index2++;
    }

    cout << "\n\n The Concatenated String is : ";
    for (int i = 0; i < max; i++)
        cout << " " << c[i];

    cout << "\n\n";
}

int main()
{
    char str1[30], str2[30], str3[30];
    int size;

    cout << " Enter the 1st String : ";
    cin >> str1;

    cout << " Enter the 2nd String : ";
    cin >> str2;

    cout << " Enter the Maximum Size of the Concatenated String : ";
    cin >> size;

    concat(str1, str2, str3, size);

    return 0;
}

