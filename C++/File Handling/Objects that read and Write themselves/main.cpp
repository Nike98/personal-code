///
/**
 *      WAP in file handling which should have an object
 *      that read and write themselves.
 */
///


#include<iostream>
#include<fstream>

using namespace std;

class Person
{
protected:
    char name[40];
    int age;

public:
    void getData()
    {
        cout << " Enter the Name : ";
        cin >> name;
        cout << " Enter the Age : ";
        cin >> age;
    }

    void showData()
    {
        cout << " Name : " << name << endl;
        cout << " Age : " << age << endl;
    }
};

int main()
{
    Person pers;
    char ch;
    int count = 0;

    fstream file;
    file.open("person.dat", ios::binary|ios::out|ios::in);

    do {
        cout << "\n Enter the Person's data..." << endl;
        pers.getData();
        file.write((char*)&pers, sizeof(pers));

        cout << "\n Enter another Person (y/n)? : ";
        cin >> ch;
        count++;
    } while (ch == 'y');

    file.seekg(0, ios::end);

    int end_pos = file.tellg();

    int n = end_pos / sizeof(pers);

    cout << "\n There are " << count << " persons in the file" << endl;

    cout << "\n Enter the Person Number : ";
    cin >> n;

    int position = (n-1)*sizeof(pers);
    file.seekg(position);
    file.read((char*)&pers, sizeof(pers));

    pers.showData();

    return 0;
}
