///
/**
 *      Create 2 classes called Time24 and Time12 with necessary
 *      data members. Write a program, to convert Time24 to
 *      Time12 using operator overloading function
 */
///

#include<iostream>
#include<string>

using namespace std;

class time12
{
private:
    bool pm;                        // true = pm, false = am
    int hrs;                        // 1 to 12
    int mins;                       // 0 to 59

public:                             // no arg Constructor
    time12() : pm(true), hrs(0), mins(0)
    {  }
                                    // 3 args Constructor
    time12(bool ap, int h, int m) : pm(ap), hrs(h), mins(m)
    {  }

    void Display()const             // format: 11:59 p.m.
    {
        cout << hrs << ':';
        if (mins < 10)
            cout << '0';            // Extra zero for values like 01
        cout << mins << ' ';
        string am_pm = pm ? "p.m." : "a.m.";
        cout << am_pm;
    }
};
// End of class time12

class time24
{
private:
    int hours;                      // 0 to 23
    int minutes;                    // 0 to 59
    int seconds;                    // 0 to 59

public:                             // no arg Constructor
    time24() : hours(0), minutes(0), seconds(0)
    {  }
                                    // 3 args Constructor
    time24(int h, int m, int s) : hours(h), minutes(m), seconds(s)
    {  }

    void Display()const             // format: 14:30:06
    {
        if (hours < 10)     cout << '0';
        cout << hours << ':';
        if (minutes < 10)   cout << '0';
        cout << minutes << ':';
        if (seconds < 10)   cout << '0';
        cout << seconds;
    }

    operator time12()const;         // conversion Operator
};

time24 :: operator time12()const    // Conversion Operator body
{
    int hrs24 = hours;
    bool pm = hours < 12 ? false : true;        //find am / pm
                                                // round mins
    int roundMins = seconds < 30 ? minutes : minutes + 1;
    if (roundMins == 60)                        // carry mins
    {
        roundMins = 0;
        ++hrs24;
        if (hrs24 == 12 || hrs24 == 24)         // carry hrs
            pm = (pm == true) ? false : true;   // toggle am / pm
    }
    int hrs12 = (hrs24 < 13) ? hrs24 : hrs24 - 12;

    if (hrs12 == 0)                             // 00 is 12 a.m.
    {
        hrs12 = 12;
        pm = false;
    }
    return time12(pm, hrs12, roundMins);
}

int main()
{
    int h, m, s;

    while (true){                          // get 24hr time from the User
        cout << " Enter 24-hour time : \n";
        cout << "\t Hours (0 to 23) : ";
        cin >> h;
        if (h > 23)                        // quit if hours > 23
            return (1);
        cout << "\t Minutes : ";
        cin >> m;
        cout << "\t Seconds : ";
        cin >> s;

        time24 t24(h, m, s);               // make a time24 object
        cout << "\n\n You Entered : ";     // Display the time24
        t24.Display();

        time12 t12 = t24;                  // Convert time12 to time24

        cout << "\n\n 12-Hour time : ";    // display equivalent time12
        t12.Display();
        cout << "\n\n";
    }
    return 0;
}
