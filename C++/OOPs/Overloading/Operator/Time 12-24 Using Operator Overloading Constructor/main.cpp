///
/**
 *      Create 2 classes called Time24 and Time12 with necessary data members.
 *      Write a program to convert Time24 to Time12 using constructor.
 */
///

#include<iostream>
#include<string>

using namespace std;

class time24
{
private:
    int hours;                              // 0 to 23
    int minutes;                            // 0 to 59
    int seconds;                            // 0 to 59

public:                                     // no arg Constructor
    time24() : hours(0), minutes(0), seconds(0)
    {  }
                                            // 3 args Constructor
    time24(int h, int m, int s) : hours(h), minutes(m), seconds(s)
    {  }

    void Display()const                     // format: 23:18:06
    {
        if (hours < 10)
            cout << '0';
        cout << hours << ':';
        if (minutes < 10)
            cout << '0';
        cout << minutes << ':';
        if (seconds < 10)
            cout << '0';
        cout << seconds;
    }

    int getHrs() const  { return hours; }
    int getMins() const { return minutes; }
    int getSecs() const { return seconds; }
};

class time12
{
private:
    bool pm;                        // true = pm, false = am
    int hrs;                        // 1 to 12
    int mins;                       // 0 to 59

public:                             // no arg Constructor
    time12() : pm(true), hrs(0), mins(0)
    {  }

    time12(time24);                 // one arg Constructor
                                    // 3 args Constructor
    time12(bool ap, int h, int m) : pm(ap), hrs(h), mins(m)
    {  }

    void Display() const
    {
        cout << hrs << ':';
        if (mins < 10)
            cout << '0';
        cout << mins << ' ';
        string am_pm = pm ? "p.m." : "a.m.";
        cout << am_pm;
    }
};

time12 :: time12(time24 t24)        // one arg Constructor
{                                   // Converts time24 to time12
    int hrs24 = t24.getHrs();       // get Hours
                                    // find am / pm
    pm = t24.getHrs() < 12 ? false : true;
                                    // round Secs
    mins = (t24.getSecs() < 30) ? t24.getMins() : t24.getMins() + 1;

    if (mins == 60){                // carry mins
        mins = 0;
        ++hrs24;
        if (hrs24 == 12 || hrs24 == 24)         // carry hrs
            pm = (pm == true) ? false : true;   // toggle am / pm
    }
    hrs = (hrs24 < 13) ? hrs24 : hrs24 - 12;    // converts hrs
    if (hrs == 0){                              // 00 is 12 a.m.
        hrs = 12;
        pm = false;
    }
}

int main()
{
    int h, m, s;

    while (true){
        cout << " Enter 24-Hour Time : \n";    // get 24-Hour time from the User
        cout << "\t Hours (0 to 23) : ";
        cin >> h;
        if (h > 23)                            // quit of Hours > 23
            return (1);
        cout << "\t Minutes : ";
        cin >> m;
        cout << "\t Seconds : ";
        cin >> s;

        time24 t24(h, m, s);                   // make an object of the time24 class
        cout << "\n\n You Entered : ";         // Display time24
        t24.Display();

        time12 t12 = t24;                      // convert time24 to time12

        cout << "\n\n 12-Hour Time : ";        // display equivalent time12
        t12.Display();
        cout << "\n\n";
    }
    return 0;
}
