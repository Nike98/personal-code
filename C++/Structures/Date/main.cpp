///
/**
 *      Create Structure of type Date that contains
 *      three members:
 *          -> The Month
 *          -> The Day of the Month
 *          -> The Year
 *
 *      Have the User enter the date in format 8/6/2012.
 *      Store it in a variable of type struct date and then
 *      retrieve the value from the variable and print them
 *      in the same format.
 */
///

#include <iostream>

using namespace std;

typedef struct Date{
    int day, month, year;
};

int main()
{
    Date date;

    cout << " Enter the Day: ";
    cin >> date.day;

    cout << " Enter the Month: ";
    cin >> date.month;

    cout << " Enter the Year: ";
    cin >> date.year;

    cout << "\n The Date: " << date.day << "/" << date.month << "/" << date.year << endl;

    return 0;
}
