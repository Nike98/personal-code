///
/**
 *      Implementing a Stack Using the Linked List Structure
 */
///

#include<iostream>
#include<stdlib.h>

using namespace std;

class Stack
{
private:
    int info, element;
    Stack *node, *link, *top;

public:
    Stack() { top = NULL; };

    void Insert();
    void Delete();
    void Display();
};

void Stack::Insert()
{
    node = new Stack;
    cout << " Enter Info : ";
    cin >> element;

    node->info = element;
    node->link = NULL;

    if (top == NULL)
        top = node;
    else {
        node->link = top;
        top = node;
    }
}

void Stack::Delete()
{
    if (top == NULL)
        cout << "\n UNDERFLOW" << endl;
    else {
        cout << "\n The Deleted Element is : " << top->info << endl;
        top = top->link;
    }
}

void Stack::Display()
{
    Stack *move;
    move = top;

    while (move != NULL){
        cout << "\n\t " << move->info;
        move = move->link;
    }
}

int main()
{
    int ch;
    Stack s;

    cout << "\n 1. INSERT" << endl;
    cout << " 2. SHOW" << endl;
    cout << " 3. DELETE" << endl;
    cout << " 4. EXIT" << endl;

    while (ch != 4){
        cout << "\n Enter your choice : ";
        cin >> ch;

        switch (ch)
        {
            case 1: s.Insert(); break;
            case 2: s.Display(); break;
            case 3: s.Delete(); break;
            case 4: exit(0);
        }
    }

    return 0;
}
