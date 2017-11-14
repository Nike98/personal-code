///
/**
  * #############################################
  *
  *         WAP using INline Function to
  *          calculate Simple Interest.
  *
  * #############################################
**/
///

#include <iostream>

using namespace std;

inline float SI(int price, float roi, float years)
{
    return price*years*roi / 100;
}

int main ()
{
    int p;
    float y, r, simInt;

    cout << " Enter the Price : ";
    cin >> p;
    cout << " Enter the Number of Years : ";
    cin >> y;
    cout << " Enter the  Rate of Interest : ";
    cin >> r;

    simInt = SI(p, r, y);

    cout << "\n The Simple Interest = " << simInt << endl;

    return 0;
}
