///
/**
 *      WAP to detect error in file operation, using ! operator.
 */
///

#include<iostream>
#include<stdlib.h>
#include<fstream>

using namespace std;

int main()
{
    ofstream fout;                      // Creating an object of the Ofstream Class
    ifstream fin;

    fin.open("sample.txt", ios::in);  // open the file in Input mode

    if (!fin){
        cout << " \n\n Error in Opening the file." << endl;
        cout << " The file is either non existent or is corrupted." << endl;
        cout << " Press any key to Exit..." << endl;
        getchar();
        exit(1);
    }
    else{
        string data;
        cout << " Enter the content to Input : ";
        getline(cin, data);
        fout << "\n\n" << data;         // Writing data to the File
        cout << "\n\n Data Append Operation was Successful!" << endl;
    }


    fin.close();
    fout.close();                       // Closing the File

    return 0;
}
