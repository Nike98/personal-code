///
/**
 *      WAP in file handling which should have an object
 *      that reads and writes themselves.
 */
///

#include<iostream>
#include<string>
#includE<fstream>

using namespace std;

class Person
{
private:
    string name;
    int age;
    ifstream file;
    char data;

public:
    void getData();
    void pushToFile();
    void searchData();
};

void Person::getData()
{
    cout << " Enter the Person's Name : ";
    cin >> name;
    cout << " Enter the Age : ";
    cin >> roll_no;
}

void Person::pushToFile()
{
    file.open("data.txt", ios::out);             // Opening the File

    if (file.is_open()){                         // Pushing the Data to the File
        fout << "\n\n Student Name : " << name << endl;
        fout << " Roll No : " << roll_no << endl;
    }
    else
        cout << "\n\n Error in performing Append operation." << endl;

    file.close();                                // Closing the File after performing the operations
}
















































