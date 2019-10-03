///
/**
 *      Write a C++ program to Swap the private data members
 *      of two different classes using a Friend Function
 */
///

#include<iostream>

using namespace std;

class Derived;

class Base
{
private:
    int num1;

public:
    Base()
    {
        cout << " Enter the value of a : ";
        cin >> num1;
    }

    void display()
    {
        cout << "\n\n The value of a is : " << num1 << endl;
    }

    friend void swap(Base *num1, Derived *num2);
};

class Derived
{
private:
    int num2;

public:
    Derived()
    {
        cout << " Enter the value of b : ";
        cin >> num2;
    }

    void display()
    {
        cout << " The value of b is : " << num2 << endl;
    }

    friend void swap(Base *num1, Derived *num2);
};

void swap(Base *n1, Derived *n2)
{
    int n3;
    n3 = n1->num1;
    n1->num1 = n2->num2;
    n2->num2 = n3;
}

int main()
{
    Base base;
    Derived derived;

    swap(&base, &derived);

    base.display();
    derived.display();

    return 0;
}
