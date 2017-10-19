#include <iostream>
#include <conio.h>

using namespace std;

inline ar_rect(int a, int b)
{
    return a * b;
}

int main ()
{
    int width, length, area;

    cout << " Enter the Width : ";
    cin >> width;
    cout << " Enter the Length : ";
    cin >> length;

    area = ar_rect (width, length);

    cout << " The Area of the Rectangle : " << area << endl;

    getch();
}
