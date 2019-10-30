///
/**
 *          Write a program to concatenate two strings
 *          using BINARY OPERATOR OVERLOADING.
 */
///

#include<iostream>
#include<string.h>
#include<stdlib.h>

using namespace std;

class String
{
private:
    enum { SZ = 80 };                  //size of the String class objects
    char str[SZ];                       // holds a String value

public:
    String()                            // Constructor with no agrs
    { strcpy(str, ""); }

    String(char s[])                    // Constructor with one arg
    { strcpy(str, s); }

    void Display()const                 // Display the String
    { cout << str; }

    String operator + (String ss)const  // add the Strings
    {
        String temp;                    // make a temporary String
        if (strlen(str) + strlen(ss.str) < SZ)
        {
            strcpy(temp.str, str);      // copy this String to temp
            strcat(temp.str, ss.str);   // Concatenate the Strings
        }
        else{
            cout << "\n\n String Overflow!" << endl;
            exit(1);
        }
        return temp;
    }
};

int main()
{
    String s1 = "\n\n Hello there! ";     // this uses Constructor 2
    String s2 = "How are you?";         // this also uses Constructor 2
    String s3;                          // this uses Constructor 1

    s1.Display();                       // display the Strings
    s2.Display();
    s3.Display();

    s3 = s1 + s2;                       // adds s2 & s1 and assigns to s3

    s3.Display();
    cout << endl;

    return 0;
}



































