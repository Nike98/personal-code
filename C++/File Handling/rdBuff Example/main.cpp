///
/**
 *      WAP which uses rdbuf() function in File Handling
 */
///

#include<iostream>
#include<string>
#include<fstream>

using namespace std;

int main()
{
    fstream file;
    file.open("sample.txt");

    // Save the instance of the original cout
    streambuf* stream_buff_out = cout.rdbuf();
    streambuf* stream_buff_in = cin.rdbuf();

    // Get the StreamBuffer of the file
    streambuf* stream_buff_file = file.rdbuf();

    // Redirect cout to the file
    cout.rdbuf(stream_buff_file);

    cout << "\nThis line is written to the File." << endl;

    // Bring cout back to it's original form and Redirect it to the Screen
    cout.rdbuf(stream_buff_out);
    cout << "\n This line is written to the Screen" << endl;

    file.close();

    return 0;
}
