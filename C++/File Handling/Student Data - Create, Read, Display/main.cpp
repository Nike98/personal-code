///
/**
 *      Write a program in C++ to input names and roll numbers
 *      of five students to a text file or a binary file. Also
 *      display the same input names from the text file just created.
 */
///


#include<iostream>
#include<string>
#include<stdlib.h>
#include<fstream>

using namespace std;

class Student
{
private:
    string name;
    int roll_no;
    ofstream fout;
    ifstream file;
    char data;

public:
    void getData();
    void pushToFile();
    void showData();
};

void Student::getData()
{
    cout << " Enter the Student Name : ";
    cin >> name;
    cout << " Enter the Roll No : ";
    cin >> roll_no;
}

void Student::pushToFile()
{
    file.open("data.txt");                  // Opening the File
    fout.open("data.txt", ios::app);        // Opening the File in Append mode

    if (!file){                             // Handling any File Errors
        cout << " \n\n Error in Opening the file." << endl;
        cout << " The file is either non existent or is corrupted." << endl;
        cout << " Press any key to Exit..." << endl;
        getchar();
        exit(1);
    }
    else{
        if (fout.is_open()){                // Pushing the Data to the File
            fout << "\n\n Student Name : " << name << endl;
            fout << " Roll No : " << roll_no << endl;
        }
        else
            cout << "\n\n Error in performing Append operation." << endl;
    }

    fout.close();
    file.close();                           // Closing the File after performing the operations
}

void Student::showData()
{
    file.open("data.txt");                  // Opening the File

    if (!file){                             // Handling any File Errors
        cout << " \n\n Error in Opening the file." << endl;
        cout << " The file is either non existent or is corrupted." << endl;
        cout << " Press any key to Exit..." << endl;
        getchar();
        exit(1);
    }
    else{
        file.seekg(0, ios::beg);
        while (file){
            data = file.get();
            cout << data;
        }
    }
    file.close();
}

int main()
{
    Student stud[10];
    Student disp_obj;

    int count = 0;
    char ch;

    // Taking the Student data Input from the User and Writing it to the File
    do{
        stud[count].getData();
        stud[count].pushToFile();
        count++;
        cout << "\n Input another value (y/n)? : ";
        cin >> ch;
        cout << "\n\n";
    } while (ch != 'n');

    cout << "*****STUDENT DATA*****" << endl;

    // Displaying the data back to the User
    disp_obj.showData();

    return 0;
}
