///
/**
 *      WAP to Open a File on Command Line
 */
///

#include<iostream>
#include<fstream>

using namespace std;

int main(int a, char *b[])
{
    if (a != 2)
        cout << " usage: " << b[0] << "<filename>\n";
    else{
        ifstream file(b[1]);

        if (!file.is_open())
            cout << " Could not open file\n";
        else{
            char x;
            while(file.get())
                cout << x;
        }
    }

    return 0;
}
