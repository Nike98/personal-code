///
/**
 *      WAP to implement stack for int and double using class templates.
 */
///

#include<iostream>

using namespace std;

const int MAX = 100;

template <class Type>
class Stack
{
private:
    Type st[MAX];                       // stack: array of any type
    int top;                            // number of the top of the stack value

public:
    Stack();                            // constructor
    void push(Type var);                // put number on the stack
    Type pop();                         // take number off the stack
};

template <class Type>
Stack<Type>::Stack()                    // constructor
{
    top = -1;
}

template<class Type>
void Stack<Type>::push(Type var)             // put number on the stack
{
    st[++top] = var;
}

template<class Type>
Type Stack<Type>::pop()                 //take number off stack
{
    return st[top--];
}

int main()
{
    Stack<int> s1;                      // s1 is an object of class Stack<int>

    s1.push(10);                        // push 3 int values and pop 3 int values
    s1.push(20);
    s1.push(30);

    cout << "1 : " << s1.pop() << endl;
    cout << "2 : " << s1.pop() << endl;
    cout << "3 : " << s1.pop() << endl;

    cout << "\n\n";

    Stack<double> s2;                   // s2 is an object of class Stack<double>

    s2.push(111.1);                     // push 3 double values and pop 3 double values
    s2.push(222.2);
    s2.push(333.3);

    cout << "1 : " << s2.pop() << endl;
    cout << "2 : " << s2.pop() << endl;
    cout << "3 : " << s2.pop() << endl;

    return 0;
}
