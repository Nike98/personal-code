///
/**
 *      WAP to implement PUSH, POP, PEEP, Display functions
 *      in a Stack using Array
 */
///

#include<iostream>
#include<stdlib.h>
#include<windows.h>

#define MAX 20

int top = -1;

using namespace std;

struct data
{
    int arr[MAX];
};

class Stack
{
private:
    data dat;

public:
    void push(int);
    void pop();
    void display();
    void peep() const;
};

void Stack::push(int element)
{
    if (top >= MAX - 1)
        cout << "\n\n STACK OVERFLOW\n" << endl;
    else{
        top = top + 1;
        dat.arr[top] = element;
        cout << "\n Element " << element << " added to the Stack.\n" << endl;
    }
}

void Stack::pop()
{
    int x;
    if (top < 0)
        cout << "\n\n STACK UNDERFLOW\n" << endl;
    else{
        x = dat.arr[top];
        cout << "\n The Deleted Element is : " << x << endl;
        top = top-1;
    }
}

void Stack::display()
{
    cout << "\n"
         << "\n Elements present in the Stack are : \n\n";
    for (int i = 0; i <= top; i++)
        cout << "  " << dat.arr[i];
    cout << "\n\n";
}

void Stack::peep() const
{
    if (top == -1)
        cout << "\n\n The Stack is Empty.\n" << endl;
    else
        cout << "\n\n The Element at the top of the Stack is : "
             << dat.arr[top] << "\n" << endl;
}

int main()
{
    Stack s;
    int choice, element;

    do {
        //system("cls");
        cout << "\n\n 1. PUSH\n"
             << " 2. POP\n"
             << " 3. PEEP\n"
             << " 4. DISPLAY\n"
             << " 5. EXIT\n\n"
             << " Enter your choice (1-5) : ";
        cin >> choice;

        switch (choice){
        case 1:
            cout << "\n Enter the Element to be Pushed to the Stack : ";
            cin >> element;
            s.push(element);
            break;
        case 2:
            s.pop();
            break;
        case 3:
            s.peep();
            break;
        case 4:
            s.display();
            break;
        }
    } while (choice < 5);

    return 0;
}
