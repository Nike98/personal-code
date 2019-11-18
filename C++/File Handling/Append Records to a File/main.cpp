///
/**
 *      WAP to append records into a File.
 */
///

#include<iostream>
#include<string>
#include<fstream>

using namespace std;

int main()
{
    ofstream fout;                      // Creating an object of the Ofstream Class
    ifstream fin;

    fin.open("sample.txt");             // open the file
    fout.open("sample.txt", ios::app);  // open the file in Append mode

    string data;
    cout << " Enter the content to Append : ";
    getline(cin, data);

    if (fin.is_open()){
        fout << "\n\n" << data;         // Writing data to the File
        cout << "\n\n Data Append Operation was Successful!" << endl;
    }
    else
        cout << " \n\n Error in performing the Append Operation." << endl;

    fin.close();
    fout.close();                       // Closing the File

    return 0;
}
