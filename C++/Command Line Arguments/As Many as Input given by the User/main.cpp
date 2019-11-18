///
/**
 *      WAP a program to read and display as many as command
 *      line arguments as input given by user.
 */
///

#include<iostream>

using namespace std;

int main(int argc, char* argv[])
{
    cout << " args = " << argc << endl;

    for (int j = 0; j < argc; j++)
        cout << " Arguments : " << j << " = " << argv[j] << endl;

    return 0;
}
