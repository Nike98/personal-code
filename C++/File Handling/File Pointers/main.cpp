///
/**
 *      WAP to demonstrate usage of File pointers.
 */
///

#include<iostream>
#include<fstream>

using namespace std;

int main()
{
    // Creating an Input stream to read the content of a file
    ifstream ifstream_obj;

    // Opening the File to read it's contents
    ifstream_obj.open("File1.txt", ios::in);

    cout << " The first location in the File : " << ifstream_obj.tellg() << "\n\n";

    char ch;

    cout << " Reading the content of the File : \n";

    // Read the whole file until EOF is not reached
    while (ifstream_obj){
        ch = ifstream_obj.get();
        cout << ch;
    }

    // Setting the EOF flag off, to allow the access to
    // open the file again for reading
    ifstream_obj.clear();

    cout << "\n\n Reading the content of the File once again : \n";

    // Setting the get pointer back at the zero byte
    // location i.e. at the beginning of the file.
    ifstream_obj.seekg(0, ios::beg);

    // Reading the content of the file again
    while (ifstream_obj){
        ch = ifstream_obj.get();
        cout << ch;
    }

    cout << "\n\n";

    return 0;
}
