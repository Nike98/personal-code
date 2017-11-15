///
/**
  * ##############################################
  *
  *       WAP that counts the number of
  *      Digits in a given Number, if an
  *  Alphabet is entered instead of a Number,
  *      the Program should not Terminate.
  * It should Display appropriate Error Message.
  *
  * ##############################################
**/
///

#include <iostream>
#include <exception>
#include <string>
#include <cstdlib>

using namespace std;

int CountDigits(int num)
{
    int i = 0;

    while (num > 0){
        num /= 10;
        i++;
    }

    return i;
}

int main ()
{
    int num = 0;
    string input;

    cout << " Enter the Digits : ";
    cin >> input;

    int i = 0;

    const char* input_arr = input.c_str();

    char c = input_arr[0];

    while (1){
        input_arr = input.c_str();

        while(c != '\0'){
            try
            {
                c = input_arr[i];
                if (! isdigit(c) && c != '\0'){
                    throw "\n Error. \n Enter Digits only.";
                }
                else{
                    i++;
                }
            }
            catch (const char* msg)
            {
                /// Reset the Program

                cout << msg << endl;
                i = 0;
                cout << "\n\n Enter the Digits : ";
                cin >> input;
                c = input_arr[0];
            }
        }   /// End of While Loop to check for Alphabets

        cout << " Number of Digits Entered = " << CountDigits(atoi(input.c_str())) << endl;
        break;

    } /// End of main While Loop

    return 0;
}
