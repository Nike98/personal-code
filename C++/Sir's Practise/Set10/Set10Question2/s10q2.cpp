///
/**
  *##############################################
  *
  *      WAP that will ask the temperature
  *        in Fahrenheit and convert it
  *                to Celsius.
  *
  *##############################################
**/
///

#include <iostream>

using namespace std;

int main ()
{
    float tempC, tempF;

    cout << " Enter the Temperature Degrees in Fahrenheit : ";
    cin >> tempF;

    tempC = (tempF - 32) * 5/9;

    cout << "\n\n The Temperature in Degrees Celsius = " << tempC << endl;

    return 0;
}
