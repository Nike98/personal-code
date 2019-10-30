///
/**
 *      Create a class Int. Overload four integer arithmetic operators
 *      (+, -, *, /) so that they operate on objects of type Int.
 *      Write a program to test this class.
 */
///

#include<iostream>

using namespace std;

class Int
{
private:
    int num;

public:
    Int()              // constructor with no args
    {}

    void getData()      // get the User Input
    {
        cout << " Enter an Integer Number : ";
        cin >> num;
    }

    void Display()      // Display the Answer after performing the operations
    { cout << num << endl; }

            // Declaring all the Operators to beOverloaded
    Int operator + (Int)const;      // ADDITION
    Int operator - (Int)const;      // SUBTRACTION
    Int operator * (Int)const;      // MULTIPLICATION
    Int operator / (Int)const;      // DIVISION
};

Int Int :: operator + (Int val)const     // returns the ADDITION
{
    Int result;
    result.num = num + val.num;
    return result;
}

Int Int :: operator - (Int val)const     // returns the SUBTRACTION
{
    Int result;
    result.num = num - val.num;
    return result;
}

Int Int :: operator * (Int val)const     // returns the MULTIPLICATION
{
    Int result;
    result.num = num * val.num;
    return result;
}

Int Int :: operator / (Int val)const     // returns the DIVISION
{
    Int result;
    result.num = num / val.num;
    return result;
}

int main()
{
    Int a, b, ans;

    a.getData();
    b.getData();

    ans = a + b;
    cout << "\n\n After ADDTION of two Objects : "; ans.Display();  cout << endl;
    ans = a - b;
    cout << " After SUBTRACTION of two Objects : "; ans.Display();  cout << endl;
    ans = a * b;
    cout << " After MULTIPLICATION of two Objects : "; ans.Display();  cout << endl;
    ans = a / b;
    cout << " After DIVISION of two Objects : "; ans.Display();  cout << endl;

    return 0;
}
