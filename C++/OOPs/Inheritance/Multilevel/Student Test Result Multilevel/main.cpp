///
/**
 *      WAP to Implement Multilevel Inheritance
 */
///

#include<iostream>

using namespace std;

class Student
{
protected:
    int roll_no;
    string name;

public:
    void getData();
};

class Test : public Student
{
protected:
    int marks1, marks2;

public:
    void Display();
};

class Result : public Test
{
private:
    int total;

public:
    void getData()
    {
        cout << " Enter the Student Name : ";
        cin >> name;
        cout << " Enter the Student Roll No : ";
        cin >> roll_no;
        cout << " Enter the Student Marks 1 : ";
        cin >> marks1;
        cout << " Enter the Student Marks 2 : ";
        cin >> marks2;
        cout << "\n\n";
    }

    void Display()
    {
        total = marks1 + marks2;

        cout << " Name : " << name << endl;
        cout << " Roll No : " << roll_no << endl;
        cout << " Total Marks : " << total << endl;
    }
};

int main()
{
    Result rs;
    rs.getData();
    rs.Display();

    return 0;
}
