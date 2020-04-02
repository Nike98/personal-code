///
/**
 *      Implementing a Stack Using the Linked List Structure
 */
///

#include<iostream>
#include<stdlib.h>

using namespace std;

struct node
{
    int data;
    node *next;
} *top, *temp, *ptr, *np;

node *create_node()                             /// Function to Create a New Node
{
    int x;
    cout << "\n Enter the value to insert : ";
    cin >> x;
    ptr = new node;                             // create a new node in the memory
    ptr->data = x;                              // set the value entered by the user as the node's data
    ptr->next = NULL;                           // set the node's next pointer to NULL
    return ptr;
}

void push(node *temp)                           /// Function to << PUSH >> or add a new node to the Stack
{
    if (top == NULL)                            // if the top of the Stack is set to NULL i.e. the Stack is Empty,
        top = temp;                             // set the newly created node as the TOP and Push it to the Stack
    else{                                       // if the Stack already has some nodes present,
        temp->next = top;                       // set the next node in the stack as Top,
        top = temp;                             // $$$$$$$$$$$$$$$$$~~~~~~~~~~~~~~~~~~~~
    }
}

void pop()                                      /// Function to << POP >> or delete a node from the Top of the Stack
{
    if (top == NULL)                            // if the Stack is empty,
        cout << "\n\n STACK UNDERFLOW\n"        // prompt the user for Underflow
             << "\n No element can be popped from the Stack, since the Stack is Empty!";
    else if (top->next == NULL){                // if the node present in the Stack is the last node,
        temp = top;                             // assign the top node to temp,
        cout << "\n\n The element Popped from the Stack was : " << temp->data   // display the user the data that was present in that node,
             << "\n\n The Stack is now Empty." << endl;                         // inform the user that the Stack is now Empty
        free(temp);                             // free up temp,
        top = NULL;                             // and set the top to NULL
    }
    else {                                      // if the Stack has more than one node(s),
        temp = top;                             // assign the value of to temp,
        top = top->next;                        // point top to the next node in the Stack
        cout << "\n\n The element Popped from the Stack was : " << temp->data;  // display the user the data of the popped node
        free(temp);                             // deallocate the memory taken up by temp
    }
}

void peep()                                     /// Function to << PEEP >> or display the data of the node at the Top of the Stack
{
    if (top == NULL)                            // if the top of the Stack does not point to anything, i.e. the Stack is Empty,
        cout << "\n\n STACK EMPTY";
    else                                        // if the Stack a node pointed to by top, print the data contained
        cout << "\n\n The element at the Top of the Stack is : " << top->data;
}

void display()
{
    cout << "\n\n";
    temp = top;
    if (temp == NULL)
        cout << " STACK EMPTY";
    else {
        while(temp != NULL){
            cout << "  " << temp->data;
            temp = temp->next;
        }
    }
    cout << "\n\n";
}

int main()
{
    top = NULL;
    int choice;

    do {
         cout << "\n\n ###### MENU ######\n\n"
             << " 1. Push\n"
             << " 2. Pop\n"
             << " 3. Peep\n"
             << " 4. Display\n"
             << " 5. Exit\n\n"
             << " Enter your choice : ";
        cin >> choice;
        switch (choice){
        case 1:
            np = create_node();
            push(np);
            break;
        case 2:
            pop();
            break;
        case 3:
            peep();
            break;
        case 4:
            display();
            break;
        }
    } while (choice < 5);
    return 0;
}
