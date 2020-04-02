///
/**
 *      WAP to implement a Single Linked List
 */
///

#include<iostream>
#include<stdlib.h>
#include<windows.h>

using namespace std;

struct node
{
    int data;
    struct node *next;
} *ptr, *head, *tail, *np, *temp, *prev;

node* CreateNode()                      /// Function to create a << Node in the Memory >>
{
    int value;
    cout << "\n\n Enter the Value to insert : ";
    cin >> value;
    ptr = new node;
    ptr->data = value;                  // Setting the value inserted by the User as the Node value
    ptr->next = NULL;                   // Setting the next address as NULL as there is no node after the current one
    return ptr;                         // returning the value of the ptr pointer
}

void InsertBegining(node *value)        /// Function to << Insert a Node at the Beginning >> of the Linked List
{
    if (head == NULL)                   // if the beginning/first node is empty,
        head = np;                      // set the first node as the value given by the User
    else {
        temp = head;                    // if the head/beginning of the list is already occupied,
        head = np;                      // set the head of the node as the value given by the User and
        np->next = temp;                // pointing the new node the previously present node and shifting it further in the list
    }
}

void InsertEnd(node *value)             /// Function to << Insert a Node at the End >> of the Linked List
{
    if (head == NULL)                   // if the head of the list is null/empty
        head = value;                   // set the new node as the first node
    else{
        temp = head;                    // if the list already contains some one or more nodes,
        while (temp->next != NULL)      // traverse through list till you reach the last node
            temp = temp->next;
        temp->next = value;             // when you reach the last node, set up a new node after it and point the previous one to the new one
    }
}

void DeleteBeginning()                  /// Function to << Delete a Node at the Beginning >> of the Linked List
{
    if (head == NULL)                   // if the list is empty, prompt the User that no Deletion can be performed
        cout << "\n\n <<< LIST EMPTY >>>\n"
             << " Cannot perform node Deletion as there are no nodes in the current list.\n" << endl;
    else{
        temp = head;                    // if the List is not empty, select the head/first node of the list
        cout << "\n\n The Deleted Node contained the value : " << temp->data << endl;
        delete(temp);                   // delete the node,
        head = head->next;              // set the next node in the list as the head/first node
    }
}

void DeleteEnd()                        /// Function to << Delete a Node at the End >> of the Linked List
{
    temp = head;                        // set the current node as the head/ first node,
    prev = temp;                        // set the previous node as the current node only, as there is no node present before it
    while (temp->next != NULL){         // traverse through the linked list till you reach the last node
        prev = temp;
        temp = temp->next;
    }
    cout << "\n\n The Deleted Node contained the value : " << temp->data << endl;
    prev->next = NULL;                  // unlink the last node from the list by setting it as null
}

void Display()                          /// Function to << Display >> the Linked List
{
    cout << "\n";
    temp = head;
    while (temp != NULL){
        cout << "  " << temp->data;
        temp = temp->next;
    }
    cout << "\n\n";
}

int main()
{
    head = NULL;
    //np =
    //char ans = 'y';
    int choice, value;
    do {
        cout << "\n\n ###### MENU ######\n\n"
             << " 1. Insert at the Beginning\n"
             << " 2. Insert at the End\n"
             << " 3. Delete at the Beginning\n"
             << " 4. Delete at the End\n"
             << " 5. Display\n"
             << " 6. Exit\n\n"
             << "Enter your choice : ";
        cin >> choice;
        switch (choice){
        case 1:{
            np = CreateNode();
            InsertBegining(np);
            break;
        }
        case 2:{
            np = CreateNode();
            InsertEnd(np);
            break;
        }
        case 3:
            DeleteBeginning();
            break;
        case 4:
            DeleteEnd();
            break;
        case 5:
            Display();
            break;
        }
    } while (choice < 6);
    return 0;
}
