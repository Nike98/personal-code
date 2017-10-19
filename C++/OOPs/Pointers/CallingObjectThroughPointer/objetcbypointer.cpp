#include <iostream>
#include <string.h>

using namespace std;

class Student
{
private:
    string stu_name;
    int stu_roll, stu_age;
public:
    void Input ()
    {
        string name;
        int roll, age;

        stu_name = name;
        stu_roll = roll;
        stu_age = age;

        cout << " Enter the Name of the Student : ";
        cin >> stu_name;
        cout << " Enter the Roll Number of the Student : ";
        cin >> stu_roll;
        cout << " Enter the Age of the Student : ";
        cin >> stu_age;
        cout << "\n\n";
    }

    void Display ()
    {
        cout << " The Name of the Student = " << stu_name << endl;
        cout << " The Roll Number of the Student = " << stu_roll << endl;
        cout << " The Age of the Student = " << stu_age << endl;
    }
};

int main ()
{
    Student data;

    Student *ptr = &data;

    (*ptr).Input();
    (*ptr).Display();

    return 0;
}
