///
/**
 *      Create a Structure of type Date that contains 3 members,
 *      the Month, the Day of the month and the Year.
 *      Have the User enter the ate in the format 8/6/2012.
 *      Store it in a variable of type struct date then retrieve
 *      the value from the variable and print them in the same format.
 */
 ///

 #include<iostream>

 using namespace std;

 typedef struct Date{
    int day, month, year;
 };

 int main()
 {
    Date date;

    cout << "Enter the Date in DD/MM/YYYY format: ";

    cin >> date.day;    // Read the DAY
    if (cin.get() != '/'){  // make sure there is a slash between DD and MM
        cout << " expected \"/\" after DD" << endl;
        return 1;
    }

    cin >> date.month;  // Read the MONTH
    if (cin.get() != '/'){  // make sure there is a slash between MM and YYYY
        cout << " expected \"/\" after MM" << endl;
        return 1;
    }

    cin >> date.year;   // Read the YEAR

    cout << "\n The Date is : " << date.day << "/" << date.month << "/" << date.year << endl;

 }
