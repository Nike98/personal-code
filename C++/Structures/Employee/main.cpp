///
/**
 *      Create a Structure called Employee that
 *      contains two members:
 *          -> An Employee number(int) and
 *          -> Employee's Compensation(float).
 *
 *      Ask the User to fill in this data for
 *      three Employees, store it in three variables
 *      of type struct Employee, and then Display
 *      the information for each Employee.
 */
///

#include <iostream>

using namespace std;

struct Employee{
    int emp_no;
    float emp_comp;
};

int main()
{
    Employee emp1, emp2, emp3;

    // Data Input for Employee 1
    cout << " EMPLOYEE 1" << endl;
    cout << " Enter the Employee Number: ";
    cin >> emp1.emp_no;
    cout << " Enter the Employee Compensation: ";
    cin >> emp1.emp_comp;

    // Data Input for Employee 2
    cout << "\n\n EMPLOYEE 2" << endl;
    cout << " Enter the Employee Number: ";
    cin >> emp2.emp_no;
    cout << " Enter the Employee Compensation: ";
    cin >> emp2.emp_comp;

    // Data Input for Employee 2
    cout << "\n\n EMPLOYEE 3" << endl;
    cout << " Enter the Employee Number: ";
    cin >> emp3.emp_no;
    cout << " Enter the Employee Compensation: ";
    cin >> emp3.emp_comp;

    cout << "\n ##########################################################";

    // Displaying all the data entered by the User
    cout << "\n\n EMPLOYEE 1" << endl;
    cout << " Employee Number: " << emp1.emp_no << endl;
    cout << " Employee Compensation: " << emp1.emp_comp << endl;

    cout << "\n EMPLOYEE 2" << endl;
    cout << " Employee Number: " << emp2.emp_no << endl;
    cout << " Employee Compensation: " << emp2.emp_comp << endl;

    cout << "\n\n EMPLOYEE 3" << endl;
    cout << " Employee Number: " << emp3.emp_no << endl;
    cout << " Employee Compensation: " << emp3.emp_comp << endl;

    return 0;
}
