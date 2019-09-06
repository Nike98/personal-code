#include <iostream>

using namespace std;

int main()
{
    float basic_sal, hra, da;

    cout << " Enter the Basic Salary: ";
    cin >> basic_sal;

    hra = basic_sal * 0.8;
    da = basic_sal * 0.9;
    float gross_sal = hra + basic_sal + da;

    cout << "\n The HRA = " << hra << endl;
    cout << "\n The DA = " << da << endl;
    cout << "\n The Gross Salary = " << gross_sal << endl;
    return 0;
}
