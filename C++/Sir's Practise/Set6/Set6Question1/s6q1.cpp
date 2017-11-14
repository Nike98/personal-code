///
/**
  * WAP to Calculate Area of Rectangle
  * Using Inline Function.
**/
///

#include <iostream>

using namespace std;

inline int AreaRectangle ( int length, int breadth )
{
    int arRect;

    return arRect = length * breadth;
}

int main ()
{
    cout << " The Area of the Rectangle = " << AreaRectangle(3, 5) << endl;

    return 0;
}
