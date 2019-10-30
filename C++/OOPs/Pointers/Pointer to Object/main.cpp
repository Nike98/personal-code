///
/**
 *      Write a program to demonstrate a pointer to object.
 */
///

#include<iostream>

using namespace std;

class Demo
{
private:
    string name;
    int age;

public:
    void getData()
    {
        cout << " Enter the Name : ";
        cin >> name;
        cout << " Enter the Age : ";
        cin >> age;
    }

    void Display()
    {
        cout << "\n\n Name : " << name << endl;
        cout << " Age : " << age << endl;
    }
};

int main()
{
    Demo obj;
    Demo *ptr;

    obj.getData();
    ptr = &obj;
    ptr->Display();

    return 0;
}
