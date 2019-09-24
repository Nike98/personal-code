///
/**
 *      Write a program to demonstrate the Default Initialization
 *      of a Constructor Member Function of a class object of the Student's
 *      Information System, such as name, roll number, height, weight.
 */
///

#include<iostream>
#include<string>

using namespace std;

class Student
{
    string name = "Nikhil Agarwal";
    int roll_no = 22;
    float height = 5.7, weight = 80.5;

public:
    Student()
    {
        cout << "\n *****STUDENT INFORMATION*****\n" << endl;
        cout << " Student Name : " << name << endl;
        cout << " Roll No. : " << roll_no << endl;
        cout << " Height : " << height << " (ft.in)" << endl;
        cout << " Weight : " << weight << "kg" << endl;
    }
};

int main()
{
    Student stud;

    return 0;
}
