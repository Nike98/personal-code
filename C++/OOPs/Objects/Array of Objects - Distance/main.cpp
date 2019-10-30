///
/**
 *      Write a program that calculates the average of up to 100 Distances
 *      input by the user. Create an array of objects of the Distance class.
 *      To calculate the average , use add_dist() member function. You will
 *      also need a member function that divides a Distance value by an integer.
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
    Distance(){ // Default Constructor
        feet = 0;
        inches = 0;
    }

    Distance(int ft, float in){ // Constructor with 2 arguments
        feet = ft;
        inches = in;
    }

    void getDistance(){ // gets the Length from the User
        cout << " Enter the Feet : ";
        cin >> feet;

        cout << " Enter the Inches : ";
        cin >> inches;
    }

    void showDistance(){ // Displays the Distance
        cout << feet << "\'-" << inches << "\"" << endl;
    }

    void add_Distance(Distance, Distance);
    void div_Distance(Distance, int);
};

void Distance :: add_Distance(Distance d2, Distance d3){    // ADDITION OF DISTANCES
    inches = d2.inches + d3.inches;     // addition of the inches
    feet = 0;                           // for carrying the value

    if (inches >= 12.0){                // if the total inches exceed 12.0
        inches -= 12.0;                 // reset inches to 0
        feet++;                         // increase the feet count by 1
    }
    feet += d2.feet + d3.feet;          // Addition the feet
}

void Distance :: div_Distance(Distance d2, int divisor){    // DIVISION OF DISTANCES
    float fltfeet = d2.feet + d2.inches / 12.0;    // Store all the answers as one float object
    fltfeet /= divisor;                            // perform Division
    feet = int(fltfeet);                           // extract the feet value
    inches = (fltfeet - feet) * 12.0;              // extract the inches value
}

int main()
{
    Distance distarr[100];      // Array of 100 Distances
    Distance total(0, 0.0), average;
    int count = 0;              // count of Distance inputs

    char ch;                    // to take the User's response

    do {
        cout << " Enter a Distance" << endl;
        distarr[count++].getDistance();
        cout << "\n Input another value (y/n)? ";
        cin >> ch;
    } while (ch != 'n');

    for (int i = 0; i < count; i++)
        total.add_Distance(total, distarr[i]);

    average.div_Distance(total, count);     // extract the Average of all the Distances

    cout << "\n\n The Average is : ";
    average.showDistance();

    return 0;
}
