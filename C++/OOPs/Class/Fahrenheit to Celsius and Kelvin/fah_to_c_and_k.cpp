#include <iostream>
#include <conio.h>

using namespace std;

class DegreeCalculator
{
private:
    float fahrenheit;
public:
    void Input ()
    {
        float degF;
        fahrenheit = degF;
        cout << " Enter the Degrees in Fahrenheit : ";
        cin >> fahrenheit;
        cout << "\n";
    }
    void CelsiusCalc ()
    {
        float degC;

        degC = (fahrenheit - 32) * 5 / 9;                  // Formula to convert Fahrenheit to Celsius

        cout << " The Degrees in Celsius = " << degC << endl;
    }
    void KelvinCalc ()
    {
        float degK;

        degK = (fahrenheit + 459.67) * 5 / 9;             // Formula to convert Fahrenheit to Kelvin

        cout << " The Degrees in Kelvin = " << degK << endl;
    }
};

int main ()
{
    DegreeCalculator converter;
        converter.Input();
        converter.CelsiusCalc();
        converter.KelvinCalc();

    getch();
}
