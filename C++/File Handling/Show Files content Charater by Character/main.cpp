///
/**
 *      Write a C++ Program to open two files and display their contents,
 *      character by character alternatively. i.e. First character from
 *      File1 followed by the first character from file2, Second character
 *      from File1 followed by the second character from File2 and so on.
 */
///

#include<iostream>
#include<string>
#include<fstream>

using namespace std;

int main()
{
    char data1, data2;

    ifstream file1("File1.txt");
    ifstream file2("File2.txt");

    file1.seekg(0, ios::beg);
    file2.seekg(0, ios::beg);

    if (file1.is_open() && file2.is_open()){
        while (file1.good() && file2.good()){
            data1 = file1.get();
            data2 = file2.get();
            cout << data1 << data2;
        }
    }

    cout << "\n\n";

    return 0;
}
