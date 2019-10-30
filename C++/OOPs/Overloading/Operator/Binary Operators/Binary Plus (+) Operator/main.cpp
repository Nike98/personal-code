///
/**
 *          Write a program in C++ to overload the binary plus(+)
 *          operator for addition of two complex numbers.
 */
///

#include<iostream>

using namespace std;

class Distance
{
private:
    int feet;
    float inches;

public:
    Distance() : feet(0), inches(0.0)      // Constructor with no args
    { }

    Distance(int ft, float in) : feet(ft), inches(in)
    { }

    void getDistance()                      // get the Length from the User
    {
        cout << " Enter Feet : ";
        cin >> feet;
        cout << " Enter Inches : ";
        cin >> inches;
    }

    void showDistance() const               // Display the Distance
    {
        cout << " " << feet << "\'-" << inches << '\"';
    }

    Distance operator + (Distance)const;   // Add 2 Distances
};

Distance Distance :: operator + (Distance d2)const         // return the sum
{
    int f = feet + d2.feet;               // add the feet
    float i = inches + d2.inches;           // add the inches
    if (i >= 12.0){                         // if the total exceeds 12.0,
        i -= 12.0;                          // then decrease the inches by 12.0
        f++;                                // Simultaneously increase feet by 1
    }

    return Distance(f, i);                  // return Distance
}

int main ()
{
    Distance dist1, dist3, dist4;       // define the Distance objects
    dist1.getDistance();                // get dist1 from the User

    Distance dist2(11, 6.25);           // define and initialize dist2

    dist3 = dist1 + dist2;              // single '+' operator

    dist4 = dist1 + dist2 + dist3;      // multiple '+' operators

                                        // Display all the Lengths
    cout << "\n\n dist1 = ";  dist1.showDistance(); cout << endl;
    cout << " dist2 = ";  dist2.showDistance(); cout << endl;
    cout << " dist3 = ";  dist3.showDistance(); cout << endl;
    cout << " dist4 = ";  dist4.showDistance(); cout << endl;

    return 0;
}
