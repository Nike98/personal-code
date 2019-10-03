///
/**
 *      ** Insert Question Here **
 */
///

#include<iostream>

using namespace std;

void concat(int max, char a[], char b[], char c[max])
{
    int index1 = 0;
    int index2 = 0;
    const int size = 20;

    a[size], b[size];

    while (a[index1] != '\0'){
        c[index1] = a[index1];
        index1++;
    }

    while (b[index2] != '\0'){
        c[index2] = b[index2];
        index2++;
    }

    cout << "\n\n The Concatenated String is : ";
    for (int i = 0; i < index1 + index2; i++)
        cout << " " << c[i];

    cout << "\n\n";
}

int main()
{
    char a[], b[], c[];

    cout << " Enter the 1st String : ";
    cin >> a;

    cout << " Enter the 2nd String : ";
    cin >> b;

    concat(50, a, b, c);

    return 0;
}
