///
/**
 *  Design an Employee class for Reading and Displaying the Employee
 *  information. The getinfo() and displayinfo() will be used
 *  respectively. Where getinfo() will be used as a private method.
 */
///


#include <iostream>

using namespace std;

class Employee{
private:
    int emp_id;
    string emp_name, role;

    void getInfo(){
        cout << " Enter the Employee ID: ";
        cin >> emp_id;
        cout << " Enter the Employee Name: ";
        cin >> emp_name;
        cout << " Enter the Employee's Role: ";
        cin >> role;
    }

public:
    void displayInfo(){
        getInfo();
        cout << "\n\n Entered INFO..." << endl;
        cout << " ----------------------------------------------" << endl;
        cout << " Employee ID : " << emp_id << endl;
        cout << " Employee Name : " << emp_name << endl;
        cout << " Employee's Role : " << role << endl;
    }
};

int main()
{
    Employee emp;
    emp.displayInfo();

    return 0;
}
